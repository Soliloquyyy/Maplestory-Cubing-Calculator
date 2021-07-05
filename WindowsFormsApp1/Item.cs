using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //need to redo with inheritance 
    public class Item
    {
        private string[] Lines;
        private string itemType = string.Empty;

        private readonly string[] Weapon =
        {
            "STR9",
            "DEX9",
            "INT9",
            "LUK9",
            "ATT9",
            "MATT9",//5
            "CR9",
            "DMG9",
            "ALLSTATS6",
            "IED30",
            "BOSS20",//10 
            "BOSS30",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//15
            "ATT12",
            "MATT12",
            "CR12",
            "DMG12",
            "ALLSTATS9",//20
            "IED35",
            "IED40",
            "BOSS35",
            "BOSS40",
            "FILL" //25
        };

        private readonly string[] Emblem =
        {
            "STR9",
            "DEX9",
            "INT9",
            "LUK9",
            "ATT9",
            "MATT9",//5
            "CR9",
            "DMG9",
            "ALLSTATS6",
            "IED30",
            "STR12",//10
            "DEX12",
            "INT12",
            "LUK12",
            "ATT12",
            "MATT12",//15
            "CR12",
            "DMG12",
            "ALLSTATS9",
            "IED35",
            "IED40",//20
            "FILL" 
        };

        private readonly string[] Secondary =
        {
            "STR9",
            "DEX9",
            "INT9",
            "LUK9",
            "ATT9",
            "MATT9",//5
            "CR9",
            "DMG9",
            "ALLSTATS6",
            "IED30",
            "BOSS20",//10 
            "BOSS30",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//15
            "ATT12",
            "MATT12",
            "CR12",
            "DMG12",
            "ALLSTATS9",//20
            "IED35",
            "IED40",
            "BOSS35",
            "BOSS40",
            "FILL" //25
        };

        private readonly string[] Shield =
        {
            "STR9",
            "DEX9",
            "INT9",
            "LUK9",
            "ATT9",
            "MATT9",//5
            "CR9",
            "DMG9",
            "ALLSTATS6",
            "IED30",
            "BOSS20",//10 
            "BOSS30",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//15
            "ATT12",
            "MATT12",
            "CR12",
            "DMG12",
            "ALLSTATS9",//20
            "IED35",
            "IED40",
            "BOSS35",
            "BOSS40",
            "FILL" //25
        };

        private readonly string[] Hat =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "SKILLCD1s",
            "SKILLCD2s",//15
            "ADVBLESSING",
            "FILL"
        };

        private readonly string[] Top =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "FILL"
        };

        private readonly string[] Bottom =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "HYPERBODY",
            "FILL"//15
        };

        private readonly string[] Shoes =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "HASTE",
            "STR12",
            "DEX12",
            "INT12",//10
            "LUK12",
            "HP12",
            "MP12",
            "ALLSTATS9",
            "COMBATORDER",//15
            "FILL"
        };

        private readonly string[] Gloves =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "SHARPEYES",
            "STR12",
            "DEX12",
            "INT12",//10
            "LUK12",
            "HP12",
            "MP12",
            "CRITDMG",
            "ALLSTATS9",//15
            "SPEEDINFUSION",
            "FILL"
        };

        private readonly string[] Cape =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "FILL"
        };

        private readonly string[] Belt =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "FILL"
        };

        private readonly string[] Shoulder =
{
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "FILL"
        };

        private readonly string[] Accessories =
        {
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "MESOS20",
            "DROPRATE20",//15
            "FILL"
        };

        private readonly string[] Heart =
{
            "STR9",//0
            "DEX9",
            "INT9",
            "LUK9",
            "HP9",
            "MP9",//5
            "ALLSTATS6",
            "STR12",
            "DEX12",
            "INT12",
            "LUK12",//10
            "HP12",
            "MP12",
            "ALLSTATS9",
            "FILL"
        };

        private Dictionary<string, string[]> ItemMap = new Dictionary<string, string[]>();

        public Item() 
        {
            ItemMap.Add("Weapon", this.Weapon);
            ItemMap.Add("Emblem", this.Emblem);
            ItemMap.Add("Secondary", this.Secondary);
            ItemMap.Add("Shield", this.Shield);
            ItemMap.Add("Hat", this.Hat);
            ItemMap.Add("Top", this.Top);
            ItemMap.Add("Bottom", this.Bottom);
            ItemMap.Add("Shoes", this.Shoes);
            ItemMap.Add("Gloves", this.Gloves);
            ItemMap.Add("Cape", this.Cape);
            ItemMap.Add("Belt", this.Belt);
            ItemMap.Add("Shoulder", this.Shoulder);
            ItemMap.Add("Accessories", this.Accessories);
            ItemMap.Add("Heart", this.Heart);
        }

        public void setItemType(string iType)
        {
            this.itemType = iType;
            this.Lines = ItemMap[iType];
        }

        public string[] getLines()
        {
            return this.Lines;
        }

        public string getItem()
        {
            return this.itemType;
        }
    }
}
