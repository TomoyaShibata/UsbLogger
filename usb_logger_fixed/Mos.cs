using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Diagnostics;

namespace usb_logger_fixed {
    class Mos {
		// USBメモリのベンダー名、シリアル番号を取得する
		public Dictionary<string, string> GetUsbInformation() {
			Dictionary<string, string> usbInformations = new Dictionary<string, string>();
			ManagementObjectSearcher mosUsb = new ManagementObjectSearcher(
				"root\\CIMV2",
				"SELECT * FROM Win32_DiskDrive WHERE InterfaceType = 'USB'"
			);
			try {
				if (mosUsb.Get().Count > 0) {
					foreach (ManagementObject queryObj in mosUsb.Get()) {
						// PNPDeviceIDに含まれるベンダー情報とシリアル番号を取得するため
						// &区切りで配列に切り出す必要がある
						string pnpDeviceId      = queryObj["PNPDeviceID"].ToString();
						string[] arrPnpDeviceId = pnpDeviceId.Split('&');
						// ベンダー情報とシリアル番号を変数へ格納
						string usbVendorName = arrPnpDeviceId[1].Substring(4);
						string usbSerialNo   = arrPnpDeviceId[3];

						usbInformations.Add("usbVendorName", usbVendorName);
						usbInformations.Add("usbSerialNo"  , usbSerialNo);
					}
				}
			} catch (ManagementException manageExc) {
				DispException(manageExc);
			}

			return usbInformations;
		}
		
		// PC名を取得する
        public string GetPcName() {
            string pcName = null;

            ManagementObjectSearcher mosPcName = new ManagementObjectSearcher(
                "root\\CIMV2",
                "SELECT * FROM Win32_ComputerSystem"
            );

            try {
                foreach (ManagementObject queryObj in mosPcName.Get()) {
                    pcName = queryObj["Name"].ToString();
                }
            } catch (ManagementException manageExc) {
                DispException(manageExc);
            }

            return pcName;
        }

        // PCユーザ名を取得する
        public string GetPcUserName() {
            string pcUserName = "Ryou_Kanazawa";
            return pcUserName;
        }
        
        // 例外がスローされた時に出力に例外内容を表示
        public void DispException(ManagementException manageExc) {
            string exceptionMsg = "エラーコード：" + manageExc.ErrorCode + "エラー内容：" + manageExc.Message + "エラー原因：" + manageExc.Source;
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.WriteLine(exceptionMsg);
        }
    }
}
