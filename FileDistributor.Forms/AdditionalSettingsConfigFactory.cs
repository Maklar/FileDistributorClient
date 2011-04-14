using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tfs.FileDistributor.Forms {
	public class AdditionalSettingsConfigFactory {
		public static Form CreateAdditionalSettingsForm(string type) {
			switch (type) {
				case "NAS":
					return null;
				case "FTP":
					return null;
				case "GIT":
					return null;
				default:
					return null;
			}
		}
	}
}
