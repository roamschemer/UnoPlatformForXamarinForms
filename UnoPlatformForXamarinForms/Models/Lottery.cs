using System;
using System.Collections.Generic;
using System.Text;
using UnoPlatformForXamarinForms.Extends;

namespace UnoPlatformForXamarinForms.Models {
    public class Lottery : BindableBase {
        /// <summary>名称</summary>
        public string Name { get => name; set => SetProperty(ref name, value); }
        private string name;

        public List<string> NameList { get; }

        public Lottery(List<string> nameList) {
            NameList = nameList;
        }

        public void Action() {
            if (NameList == null) return;
            var rnd = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            Name = NameList[rnd.Next(0, NameList.Count)];
        }
    }
}
