#nullable enable

namespace Weather
{
    public class City
    {
        public readonly string name = null!;
        public readonly int id;

        public City(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }

    public class Prefecture
    {
        public readonly string name = null!;
        public readonly City[] cities = null!;

        public Prefecture(string name, City[] cities)
        {
            this.name = name;
            this.cities = cities;
        }
    }

    public static class LocationDatabase
    {
        public static readonly Prefecture[] prefectures = new Prefecture[]
        {
            new("道北",
                new City[]
                {
                    new("稚内" ,011000),
                    new("旭川" ,012010),
                    new("留萌" ,012020)
                }),

            new("道東",
                new City[]
                {
                    new("網走", 013010),
                    new("北見", 013020),
                    new("紋別", 013030),
                    new("根室", 014010),
                    new("釧路", 014020),
                    new("帯広", 014030)
                }),

            new("道南",
                new City[]
                {
                    new("室蘭", 015010),
                    new("浦河", 015020)
                }),

            new("道央",
                new City[]
                {
                    new("札幌", 016010),
                    new("岩見沢", 016020),
                    new("倶知安", 016030)
                }),

            new("道南",
                new City[]
                {
                    new("函館", 017010),
                    new("江差", 017020)
                }),

            new("青森県",
                new City[]
                {
                    new("青森", 020010),
                    new("むつ", 020020),
                    new("八戸", 020030)
                }),

            new("岩手県",
                new City[]
                {
                    new("盛岡", 030010),
                    new("宮古", 030020),
                    new("大船渡", 030030)
                }),

            new("宮城県",
                new City[]
                {
                    new("仙台", 040010),
                    new("白石", 040020)
                }),

            new("秋田県",
                new City[]
                {
                    new("秋田", 050010),
                    new("横手", 050020)
                }),

            new("山形県",
                new City[]
                {
                    new("山形", 060010),
                    new("米沢", 060020),
                    new("酒田", 060030),
                    new("新庄", 060040)
                }),

            new("福島県",
                new City[]
                {
                    new("福島", 070010),
                    new("小名浜", 070020),
                    new("若松", 070030)
                }),

            new("茨城県",
                new City[]
                {
                    new("水戸", 080010),
                    new("土浦", 080020)
                }),

            new("栃木県",
                new City[]
                {
                    new("宇都宮", 090010),
                    new("大田原", 090020)
                }),

            new("群馬県",
                new City[]
                {
                    new("前橋", 100010),
                    new("みなかみ", 100020)
                }),

            new("埼玉県",
                new City[]
                {
                    new("さいたま", 110010),
                    new("熊谷", 110020),
                    new("秩父", 110030),
                }),

            new("千葉県",
                new City[]
                {
                    new("千葉", 120010),
                    new("銚子", 120020),
                    new("館山", 120030)
                }),

            new("東京都",
                new City[]
                {
                    new("東京", 130010),
                    new("大島", 130020),
                    new("八丈島", 130030),
                    new("父島", 130040)
                }),

            new("神奈川県",
                new City[]
                {
                    new("横浜", 140010),
                    new("小田原", 140020)
                }),

            new("新潟県",
                new City[]
                {
                    new("新潟", 150010),
                    new("長岡", 150020),
                    new("高田", 150030),
                    new("相川", 150040)
                }),

            new("富山県",
                new City[]
                {
                    new("富山", 160010),
                    new("伏木", 160020)
                }),

            new("石川県",
                new City[]
                {
                    new("金沢", 170010),
                    new("輪島", 170020)
                }),

            new("福井県",
                new City[]
                {
                    new("福井", 180010),
                    new("敦賀", 180020)
                }),

            new("山梨県",
                new City[]
                {
                    new("甲府", 190010),
                    new("河口湖", 190020)
                }),

            new("長野県",
                new City[]
                {
                    new("長野", 200010),
                    new("松本", 200020),
                    new("飯田", 200030)
                }),

            new("岐阜県",
                new City[]
                {
                    new("岐阜", 210010),
                    new("高山", 210020)
                }),

            new("静岡県",
                new City[]
                {
                    new("静岡", 220010),
                    new("網代", 220020),
                    new("三島", 220030),
                    new("浜松", 220040)
                }),

            new("愛知県",
                new City[]
                {
                    new("名古屋", 230010),
                    new("豊橋", 230020)
                }),

            new("三重県",
                new City[]
                {
                    new("津", 240010),
                    new("尾鷲", 240020)
                }),

            new("滋賀県",
                new City[]
                {
                    new("大津", 250010),
                    new("彦根", 250020)
                }),

            new("京都府",
                new City[]
                {
                    new("京都", 260010),
                    new("舞鶴", 260020)
                }),

            new("大阪府",
                new City[]
                {
                    new("大阪", 270000)
                }),

            new("兵庫県",
                new City[]
                {
                    new("神戸", 280010),
                    new("豊岡", 280020)
                }),

            new("奈良県",
                new City[]
                {
                    new("奈良", 290010),
                    new("風屋", 290020)
                }),

            new("和歌山県",
                new City[]
                {
                    new("和歌山", 300010),
                    new("潮岬", 300020)
                }),

            new("鳥取県",
                new City[]
                {
                    new("鳥取", 310010),
                    new("米子", 310020)
                }),

            new("島根県",
                new City[]
                {
                    new("松江", 320010),
                    new("浜田", 320020),
                    new("西郷", 320030)
                }),

            new("岡山県",
                new City[]
                {
                    new("岡山", 330010),
                    new("津山", 330020)
                }),

            new("広島県",
                new City[]
                {
                    new("広島", 340010),
                    new("庄原", 340020)
                }),

            new("山口県",
                new City[]
                {
                    new("下関", 350010),
                    new("山口", 350020),
                    new("柳井", 350030),
                    new("萩", 350040)
                }),

            new("徳島県",
                new City[]
                {
                    new("徳島", 360010),
                    new("日和佐", 360020)
                }),

            new("香川県",
                new City[]
                {
                    new("高松", 370000)
                }),

            new("愛媛県",
                new City[]
                {
                    new("松山", 380010),
                    new("新居浜", 380020),
                    new("宇和島", 380030)
                }),

            new("高知県",
                new City[]
                {
                    new("高知", 390010),
                    new("室戸岬", 390020),
                    new("清水", 390030)
                }),

            new("福岡県",
                new City[]
                {
                    new("福岡", 400010),
                    new("八幡", 400020),
                    new("飯塚", 400030),
                    new("久留米", 400040)
                }),

            new("佐賀県",
                new City[]
                {
                    new("佐賀", 410010),
                    new("伊万里", 410020)
                }),

            new("長崎県",
                new City[]
                {
                    new("長崎", 420010),
                    new("佐世保", 420020),
                    new("厳原", 420030),
                    new("福江", 420040)
                }),

            new("熊本県",
                new City[]
                {
                    new("熊本", 430010),
                    new("阿蘇乙姫", 430020),
                    new("牛深", 430030),
                    new("人吉", 430040)
                }),

            new("大分県",
                new City[]
                {
                    new("大分", 440010),
                    new("中津", 440020),
                    new("日田", 440030),
                    new("佐伯", 440040)
                }),

            new("宮崎県",
                new City[]
                {
                    new("宮崎", 450010),
                    new("延岡", 450020),
                    new("都城", 450030),
                    new("高千穂", 450040)
                }),

            new("鹿児島県",
                new City[]
                {
                    new("鹿児島", 460010),
                    new("鹿屋", 460020),
                    new("種子島", 460030),
                    new("名瀬", 460040)
                }),

            new("沖縄県",
                new City[]
                {
                    new("那覇", 471010),
                    new("名護", 471020),
                    new("久米島", 471030),
                    new("南大東", 472000),
                    new("宮古島", 473000),
                    new("石垣島", 474010),
                    new("与那国島", 474020)
                }),
        };
    }
}