using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tfs.FileDistributor.Forms {

	public class UploadSettingsConfigSection : ConfigurationSection {
		[ConfigurationProperty("UploadSettings", IsDefaultCollection = true)]	
		public UploadSettingCollection UploadSettings {
			get { return ((UploadSettingCollection)base["UploadSettings"]); }
		}
	}

	
	[ConfigurationCollection(typeof(UploadElement), AddItemName = "UploadSetting")]
	public class UploadSettingCollection : ConfigurationElementCollection {
		protected override ConfigurationElement CreateNewElement() {
			return new UploadElement();
		}

		protected override object GetElementKey(ConfigurationElement element) {
			return ((UploadElement)element).UploadType.GetHashCode() + ((UploadElement)element).Description.GetHashCode();
		}

		public UploadElement this[int index] {
			get { return (UploadElement)BaseGet(index); }
		}

		public void Add(UploadElement element) {
			base.BaseAdd(element);
		}

		public void Remove(UploadElement element) {
			int index = base.BaseIndexOf(element);
			if (index >= 0)
				base.BaseRemoveAt(index);
		}
	}

	public class UploadElement : ConfigurationElement {
		public override bool IsReadOnly() {
			return false;
		}

		[ConfigurationProperty("uploadType", IsRequired = true)]
		public string UploadType {
			get { return (string)this["uploadType"]; }
			set { this["uploadType"] = value; }
		}

		[ConfigurationProperty("active", DefaultValue=false, IsRequired = true)]
		public bool Active {
			get { return (bool)this["active"]; }
			set { this["active"] = value; }
		}

		[ConfigurationProperty("color", IsRequired=false)]
		public int Color {
			get { return (int)this["color"]; }
			set { this["color"] = value; }
		}

		[ConfigurationProperty("description", IsRequired = false)]
		public string Description {
			get { return (string)this["description"]; }
			set { this["description"] = value; }
		}

		[ConfigurationProperty("AdditionalSettings", IsDefaultCollection = false)]
		public AdditionalUploadSettingCollection AdditionalSettings {
			get { return ((AdditionalUploadSettingCollection)base["AdditionalSettings"]); }
		}
	}

	[ConfigurationCollection(typeof(AdditionalUploadElement), AddItemName = "Add")]
	public class AdditionalUploadSettingCollection : ConfigurationElementCollection {
		protected override ConfigurationElement CreateNewElement() {
			return new AdditionalUploadElement();
		}

		protected override object GetElementKey(ConfigurationElement element) {
			return ((AdditionalUploadElement)element).Name;
		}

		public AdditionalUploadElement this[int index] {
			get { return (AdditionalUploadElement)BaseGet(index); }
		}

		public void Add(AdditionalUploadElement element) {
			base.BaseAdd(element);
		}

		public void Remove(AdditionalUploadElement element) {
			int index = base.BaseIndexOf(element);
			if (index >= 0)
				base.BaseRemoveAt(index);
		}
	}

	public class AdditionalUploadElement : ConfigurationElement {
		[ConfigurationProperty("name", IsRequired = true)]
		public string Name {
			get { return (string)this["name"]; }
			set { this["name"] = value; }
		}

		[ConfigurationProperty("value", IsRequired = true)]
		public string Value {
			get { return (string)this["value"]; }
			set { this["value"] = value; }
		}
	}
}
