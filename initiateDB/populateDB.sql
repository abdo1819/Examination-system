

/* -------------------------------------------------------------------------- */
/*                                  POPULATE DB                               */
/* -------------------------------------------------------------------------- */

USE EXAMINATION
GO

/* ------------------------------------------------------------------------------- */
/*                                 Department Table                                */
/* ------------------------------------------------------------------------------- */

DECLARE @dept_id1 INTEGER, @mgr_id1 INTEGER;
DECLARE @dept_id2 INTEGER, @mgr_id2 INTEGER;
DECLARE @dept_id3 INTEGER, @mgr_id3 INTEGER;
DECLARE @dept_id4 INTEGER, @mgr_id4 INTEGER;
DECLARE @dept_id5 INTEGER, @mgr_id5 INTEGER;
DECLARE @dept_id6 INTEGER, @mgr_id6 INTEGER;
DECLARE @dept_id7 INTEGER, @mgr_id7 INTEGER;
DECLARE @dept_id8 INTEGER, @mgr_id8 INTEGER;
DECLARE @dept_id9 INTEGER, @mgr_id9 INTEGER;

EXEC Insert_Department_With_Manager @dept_name = "Product Management",@f_name = "Cyril", @l_name="Bartolic",@address="1240 Fuller Road",@email="cbartolic0@fotki.com",@password="7ChH2e4",@salary=10220.08,@degree="Administrative Assistant II",@dept_id=@dept_id1 output ,@mgr_id=@mgr_id1 output;
EXEC Insert_Department_With_Manager @dept_name = "Services",@f_name = "Zandra", @l_name="Boumphrey",@address="8116 Birchwood Avenue",@email="zboumphrey1@blogspot.com",@password="Me82spWN",@salary=13438.20,@degree="Operator",@dept_id=@dept_id2 output ,@mgr_id=@mgr_id2 output;
EXEC Insert_Department_With_Manager @dept_name = "Training",@f_name = "Ric", @l_name="Glitherow",@address="087 Schlimgen Point",@email="rglitherow2@networkadvertising.org",@password="dThzSa",@salary=9710.61,@degree="Financial Advisor",@dept_id=@dept_id3 output ,@mgr_id=@mgr_id3 output;
EXEC Insert_Department_With_Manager @dept_name = "gaming",@f_name = "Yehudit", @l_name="Cowe",@address="2722 Forest Dale Parkway",@email="ycowe3@nbcnews.com",@password="Twtb0dx",@salary=12452.65,@degree="Senior Editor",@dept_id=@dept_id4 output ,@mgr_id=@mgr_id4 output;
EXEC Insert_Department_With_Manager @dept_name = "Marketing",@f_name = "Lincoln", @l_name="Reightley",@address="965 Dunning Point",@email="lreightley4@eventbrite.com",@password="YHAim9IO",@salary=8894.54,@degree="Human Resources Manager",@dept_id=@dept_id5 output ,@mgr_id=@mgr_id5 output;
EXEC Insert_Department_With_Manager @dept_name = "electronics",@f_name = "Dominique", @l_name="Mabe",@address="5769 Dakota Crossing",@email="dmabe5@sakura.ne.j@",@password="Ng3jObwzkvUD",@salary=14194.15,@degree="Human Resources Manager",@dept_id=@dept_id6 output ,@mgr_id=@mgr_id6 output;
EXEC Insert_Department_With_Manager @dept_name = "Business Development",@f_name = "Siward", @l_name="Hallen",@address=null,@email="shallen6@shareasale.com",@password="fUDJoi7a0jS8",@salary=null,@degree=null,@dept_id=@dept_id7 output ,@mgr_id=@mgr_id7 output;
EXEC Insert_Department_With_Manager @dept_name = "AI",@f_name = "Andrej", @l_name="Fernley",@address="2767 Lerdahl Street",@email="afernley7@mayoclinic.com",@password="oNUdJ1",@salary=9619.06,@degree="Statistician I",@dept_id=@dept_id8 output ,@mgr_id=@mgr_id8 output;
EXEC Insert_Department_With_Manager @dept_name = "Accounting",@f_name = "Melli", @l_name="Goolding",@address="876 Briar Crest Court",@email="mgoolding8@pinterest.com",@password="5s5eB2RLTj",@salary=9427.22,@degree="Sales Representative",@dept_id=@dept_id9 output ,@mgr_id=@mgr_id9 output;

/* ------------------------------------------------------------------------------- */
/*                                Instructors Table                                */
/* ------------------------------------------------------------------------------- */

declare @temp_ins_id int;
EXEC Insert_Instructor @f_name="Trixie",@l_name="Lysaght",@address="11415 Harbort Junction",@email="tlysaght9@typepad.com",@password="5aggh2Pr57o",@salary=14886.31,@degree="Dental Hygienist",@dept_id=@dept_id6,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Alasteir",@l_name="Cassell",@address=null,@email="acassella@wiley.com",@password="O8aznOoZ",@salary=null,@degree=null,@dept_id=@dept_id9,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Gard",@l_name="MacElroy",@address="50172 Sauthoff Court",@email="gmacelroyb@wunderground.com",@password="uARdwqQq6T",@salary=13262.15,@degree="Help Desk Technician",@dept_id=@dept_id5,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Darryl",@l_name="Thyer",@address="399 Bobwhite Avenue",@email="dthyerc@loc.gov",@password="7qffhuNxhS",@salary=12296.11,@degree="Teacher",@dept_id=@dept_id1,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Rikki",@l_name="Offen",@address="9333 Ludington Pass",@email="roffend@dell.com",@password="bTfEHp",@salary=9214.95,@degree="Health Coach I",@dept_id=@dept_id6,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Francoise",@l_name="Faichnie",@address="80 Michigan Court",@email="ffaichniee@so-net.ne.jp",@password="eTbucib",@salary=12963.95,@degree="Help Desk Operator",@dept_id=@dept_id6,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Barry",@l_name="Grattage",@address="7075 Karstens Alley",@email="bgrattagef@hhs.gov",@password="UIB79ll6mRvi",@salary=12692.20,@degree="Marketing Manager",@dept_id=@dept_id2,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Gran",@l_name="Couvet",@address="81 Melvin Street",@email="gcouvetg@altervista.org",@password="L2vnC5S5y",@salary=12651.12,@degree="Sales Associate",@dept_id=@dept_id8,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Ulla",@l_name="Mollindinia",@address="710 Melody Place",@email="umollindiniah@163.com",@password="iYnGHOh5iQBt",@salary=8790.06,@degree="Geological Engineer",@dept_id=@dept_id9,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Zita",@l_name="Zanni",@address="7980 Kipling Road",@email="zzannii@canalblog.com",@password="30fNQoV0tkf",@salary=8221.69,@degree="Senior Editor",@dept_id=@dept_id3,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Trueman",@l_name="Wherrit",@address="799 Schlimgen Point",@email="twherritj@digg.com",@password="4cmaHrUJ",@salary=9280.96,@degree="Professor",@dept_id=@dept_id4,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Ag",@l_name="Ord",@address="0447 Di Loreto Alley",@email="aordk@theatlantic.com",@password="6NbelaUsdn8",@salary=14855.39,@degree="Geological Engineer",@dept_id=@dept_id5,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Shelley",@l_name="Maymand",@address="723 Pawling Circle",@email="smaymandl@va.gov",@password="aIjLSgD64",@salary=10470.31,@degree="Human Resources Assistant II",@dept_id=@dept_id3,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Kelcy",@l_name="Mattheis",@address="80061 Butternut Park",@email="kmattheism@sphinn.com",@password="nd1qBWp",@salary=12795.18,@degree="Research Nurse",@dept_id=@dept_id6,@ins_id=@temp_ins_id output;
EXEC Insert_Instructor @f_name="Rowe",@l_name="Dewes",@address="635 Eastwood Pass",@email="rdewesn@amazonaws.com",@password="0Jy1ayRz",@salary=11888.25,@degree="Associate Professor",@dept_id=@dept_id3,@ins_id=@temp_ins_id output;

/* ------------------------------------------------------------------------------- */
/*                                    Student Table                                */
/* ------------------------------------------------------------------------------- */

DECLARE @temp_std_id int;
EXEC Insert_Student @f_name="Cristin",@l_name="Hutcheon",@address="88 Northwestern Center",@email="chutcheono@wunderground.com",@password="fDt7Abj5L0uU",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Camille",@l_name="Farnworth",@address="3695 Orin Crossing",@email="cfarnworthp@wired.com",@password="IKmSCbgjK5",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Skippie",@l_name="Schultheiss",@address="9 Ridgeway Hill",@email="sschultheissq@tinypic.com",@password="GVtbYFnvH",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Eula",@l_name="Cadge",@address="36556 Express Circle",@email="ecadger@dedecms.com",@password="sVSf0zB",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Fernande",@l_name="Iveagh",@address="80 Esch Alley",@email="fiveaghs@chron.com",@password="LJpxyi6Kyf",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Shena",@l_name="Alenichev",@address="10829 Farragut Parkway",@email="salenichevt@wsj.com",@password="YD6HTYypp",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Ezra",@l_name="di Rocca",@address="0770 Artisan Junction",@email="ediroccau@state.tx.us",@password="j4ZkANghHoa",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Jefferey",@l_name="Lamminam",@address="98007 Northfield Hill",@email="jlamminamv@cloudflare.com",@password="oU3zz29lA",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Dinnie",@l_name="Lagen",@address="581 Manley Hill",@email="dlagenw@rediff.com",@password="ticPYREiDq",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Florrie",@l_name="Heeney",@address="103 Arrowood Drive",@email="fheeneyx@engadget.com",@password="QMApPBrcgMx",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Fredericka",@l_name="McAdam",@address="0 Moulton Hill",@email="fmcadamy@storify.com",@password="gQnd1OVr",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Terrel",@l_name="Goldsmith",@address="509 Steensland Lane",@email="tgoldsmithz@pen.io",@password="hHPzD2tj0u",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Tierney",@l_name="Gasparro",@address="1793 Lakewood Gardens Plaza",@email="tgasparro10@trellian.com",@password="vjm2nN",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Maximo",@l_name="Cuttin",@address="678 Lien Circle",@email="mcuttin11@pbs.org",@password="b9t9UeHCQLYN",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Marlane",@l_name="Stell",@address="24 Springs Junction",@email="mstell12@harvard.edu",@password="azZrCSZ",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Miof mela",@l_name="Dillamore",@address="6789 Knutson Drive",@email="mdillamore13@chronoengine.com",@password="GabP28HrXy",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Deane",@l_name="Morsey",@address="2717 Village Street",@email="dmorsey14@huffingtonpost.com",@password="UkU5vlryw",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Rahal",@l_name="Schruur",@address="356 Mallory Terrace",@email="rschruur15@people.com.cn",@password="31mCeDmZdvI",@dept_id=@dept_id8,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Faye",@l_name="Alvares",@address="64 Stoughton Pass",@email="falvares16@upenn.edu",@password="ftMkNMgJJ",@dept_id=@dept_id8,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Cathleen",@l_name="Mourant",@address="6 Dovetail Drive",@email="cmourant17@goo.ne.jp",@password="QG259V69",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Abel",@l_name="Garthland",@address="53 Warner Pass",@email="agarthland18@stumbleupon.com",@password="teEqAFBFje",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Carena",@l_name="Secker",@address="81 Center Court",@email="csecker19@nifty.com",@password="5d5Pe8v",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Cindra",@l_name="Huckett",@address="04360 Di Loreto Drive",@email="chuckett1a@ning.com",@password="p618muDt1e",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Bernadette",@l_name="Buddell",@address="6 Darwin Road",@email="bbuddell1b@cloudflare.com",@password="L9CeDUB",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Thorsten",@l_name="Leyfield",@address="668 Northfield Street",@email="tleyfield1c@merriam-webster.com",@password="qW94JKVDBIQ",@dept_id=@dept_id8,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Pieter",@l_name="Willas",@address="0836 Del Mar Court",@email="pwillas1d@github.io",@password="XTBz7z",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Jamie",@l_name="Floyd",@address=null,@email="jfloyd1e@delicious.com",@password="bKTQdAsa",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Aurel",@l_name="Gooderridge",@address="24599 Mallard Avenue",@email="agooderridge1f@zimbio.com",@password="i28IpzQLA7",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Kit",@l_name="Stirman",@address="840 Almo Alley",@email="kstirman1g@yellowpages.com",@password="vu33kPl",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Emelyne",@l_name="Bernardet",@address="6 Buhler Drive",@email="ebernardet1h@topsy.com",@password="rPU3LwW4PIc",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Mella",@l_name="Gommes",@address="34 Hanson Place",@email="mgommes1i@rediff.com",@password="8cDP3Dk",@dept_id=@dept_id5,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lissie",@l_name="Dawber",@address="81799 Kingsford Court",@email="ldawber1j@oaic.gov.au",@password="8UL06DMS",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Oriana",@l_name="Connechy",@address="57 Clarendon Center",@email="oconnechy1k@miibeian.gov.cn",@password="Wp0bXj7UJqK",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Aimee",@l_name="Frigot",@address="66 Moose Lane",@email="afrigot1l@geocities.jp",@password="QMqB1afviOf",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Noel",@l_name="Riveles",@address="75566 Fulton Plaza",@email="nriveles1m@deviantart.com",@password="xuw5kB",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lee",@l_name="Matthesius",@address="9039 Portage Junction",@email="lmatthesius1n@cnbc.com",@password="96s6on",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Son",@l_name="Elecum",@address="156 Artisan Terrace",@email="selecum1o@abc.net.au",@password="ISjMTCvKy",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Margareta",@l_name="Lambswood",@address="75 Brown Street",@email="mlambswood1p@etsy.com",@password="kbvnBCg6Iv",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Tanner",@l_name="Edlington",@address="3 Veith Hill",@email="tedlington1q@shop-pro.jp",@password="44H0YSt",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Barth",@l_name="Friedman",@address=null,@email="bfriedman1r@t.co",@password="1UKQpda",@dept_id=@dept_id2,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Linell",@l_name="Courtes",@address="686 Kennedy Drive",@email="lcourtes1s@cafepress.com",@password="k5KXr4Y31",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Ruby",@l_name="Bramley",@address="354 Mccormick Road",@email="rbramley1t@wordpress.com",@password="RTtRYtKYZw",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Ludovika",@l_name="Gilbart",@address="3 Lunder Avenue",@email="lgilbart1u@surveymonkey.com",@password="mb00Dmh",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Linus",@l_name="Fiveash",@address="8993 Northland Plaza",@email="lfiveash1v@yandex.ru",@password="8Ljh8V0srf",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Camel",@l_name="Marley",@address="819 Jenifer Plaza",@email="cmarley1w@china.com.cn",@password="QstEb92oP",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Gerry",@l_name="Ruggieri",@address="05 Kingsford Court",@email="gruggieri1x@chronoengine.com",@password="5nVmJaD2Bp",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Sinclare",@l_name="Karpman",@address=null,@email="skarpman1y@istockphoto.com",@password="en1h4a1Wwesj",@dept_id=@dept_id8,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Edith",@l_name="MacAdie",@address=null,@email="emacadie1z@webeden.co.uk",@password="xThdrmbwX",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Pauline",@l_name="Triggs",@address="18 Dovetail Junction",@email="ptriggs20@dedecms.com",@password="xyHjutRHgog",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Erhart",@l_name="O'Lyhane",@address="8050 Alpine Court",@email="eolyhane21@indiatimes.com",@password="ibDPr7",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Constancia",@l_name="Merrison",@address="8 Moose Pass",@email="cmerrison22@hc360.com",@password="PJZk6lC",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Baillie",@l_name="Water",@address="85595 Kingsford Way",@email="bwater23@go.com",@password="pnagLA3xQS",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Carlen",@l_name="Osgerby",@address=null,@email="cosgerby24@plala.or.jp",@password="X7v5XI8Kxm",@dept_id=@dept_id2,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lane",@l_name="Ligoe",@address="728 Merry Point",@email="lligoe25@example.com",@password="GTdmhy5rD",@dept_id=@dept_id2,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Bastien",@l_name="Pinson",@address="9473 Saint Paul Place",@email="bpinson26@amazon.com",@password="cpN09lsI9Ww",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lanna",@l_name="Krauss",@address="0 Northfield Alley",@email="lkrauss27@topsy.com",@password="5PFMBao5",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Shea",@l_name="Kitchener",@address="451 Milwaukee Circle",@email="skitchener28@berkeley.edu",@password="sczrEuS",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lek",@l_name="Dowsey",@address="97337 Blackbird Way",@email="ldowsey29@barnesandnoble.com",@password="zvYwMAFkyeZx",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Loren",@l_name="Oliva",@address="3558 Westerfield Alley",@email="loliva2a@shareasale.com",@password="ASoH3kQiqEFA",@dept_id=@dept_id2,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Nessi",@l_name="Mor",@address="98422 Melody Pass",@email="nmor2b@cbsnews.com",@password="800KKmxsqOD",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Arvin",@l_name="Penhallurick",@address="0 Autumn Leaf Trail",@email="apenhallurick2c@sourceforge.net",@password="DqCW86DKW",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Moyra",@l_name="Turvie",@address=null,@email="mturvie2d@dagondesign.com",@password="GDbZaYCXpxF4",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Tiler",@l_name="Meere",@address="026 Coleman Pass",@email="tmeere2e@drupal.org",@password="jw3AjE",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Marven",@l_name="Worthington",@address=null,@email="mworthington2f@aboutads.info",@password="RgoqVLN7V",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Adrien",@l_name="Prover",@address="38 Lyons Way",@email="aprover2g@uiuc.edu",@password="mSsQ9lAJAih",@dept_id=@dept_id3,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Parrnell",@l_name="Constanza",@address="9 6th Circle",@email="pconstanza2h@trellian.com",@password="Ef4KWamxK9i",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Jacquelynn",@l_name="Caris",@address="21732 Alpine Junction",@email="jcaris2i@wp.com",@password="2rYKvkvJ",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Theadora",@l_name="Borel",@address="8 Hanson Alley",@email="tborel2j@rakuten.co.jp",@password="U7FTHuqsjS",@dept_id=@dept_id6,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Caralie",@l_name="Rummins",@address="490 Fairfield Center",@email="crummins2k@skyrock.com",@password="b9eJaTr6D5",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Emalia",@l_name="Hassin",@address="101 Fordem Junction",@email="ehassin2l@behance.net",@password="ERN6QoZ0kY7l",@dept_id=@dept_id7,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Brnaby",@l_name="Rossander",@address="271 Lien Circle",@email="brossander2m@de.vu",@password="zlOHzLVPXo",@dept_id=@dept_id4,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lyle",@l_name="Meneer",@address="2 Kinsman Drive",@email="lmeneer2n@de.vu",@password="vJCqbxXB",@dept_id=@dept_id8,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Essie",@l_name="Batchelour",@address=null,@email="ebatchelour2o@twitter.com",@password="rX1UM7",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Vivi",@l_name="Druhan",@address="1776 Carioca Lane",@email="vdruhan2p@economist.com",@password="DyImuF",@dept_id=@dept_id1,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Gloriane",@l_name="Besnardeau",@address="14 Luster Drive",@email="gbesnardeau2q@theatlantic.com",@password="HlzCxkcVpjjA",@dept_id=@dept_id9,@stu_id=@temp_std_id output;
EXEC Insert_Student @f_name="Lorne",@l_name="Foxen",@address=null,@email="lfoxen2r@google.com.hk",@password="ixaK4O",@dept_id=@dept_id3,@stu_id=@temp_std_id output;

/* ------------------------------------------------------------------------------- */
/*                                      Course Table                               */
/* ------------------------------------------------------------------------------- */

USE Examination
GO

EXEC Insert_Course @crs_name = 'Programming Basics'
GO
EXEC Insert_Course @crs_name = 'SQL'
GO
EXEC Insert_Course @crs_name = 'CST'
GO
EXEC Insert_Course @crs_name = 'Advanced CST'
GO
EXEC Insert_Course @crs_name = '.NET Core'
GO

/* ------------------------------------------------------------------------------- */
/*                                      Topic Table                                */
/* ------------------------------------------------------------------------------- */

EXEC Insert_Topic @top_name = 'C Language', @crs_name = 'Programming Basics'
GO
EXEC Insert_Topic @top_name = 'C++ OOP', @crs_name = 'Programming Basics'
GO
EXEC Insert_Topic @top_name = 'Software Architecture', @crs_name = 'Programming Basics'
GO
EXEC Insert_Topic @top_name = 'Database' , @crs_name = 'SQL'
GO
EXEC Insert_Topic @top_name = 'Advanced Database', @crs_name = 'SQL'
GO
EXEC Insert_Topic @top_name = 'HTML', @crs_name = 'CST'
GO
EXEC Insert_Topic @top_name = 'CSS', @crs_name = 'CST'
GO
EXEC Insert_Topic @top_name = 'Javascript', @crs_name = 'CST'
GO
EXEC Insert_Topic @top_name = 'Advanced Javascript', @crs_name = 'Advanced CST'
GO
EXEC Insert_Topic @top_name = 'HTML5', @crs_name = 'Advanced CST'
GO
EXEC Insert_Topic @top_name = 'C#', @crs_name = '.NET Core'
GO

/* ------------------------------------------------------------------------------- */
/*                                 Ins_Course Table                                */
/* ------------------------------------------------------------------------------- */
Insert_Topic 'ASP.NET', '.NET Core'
GO
Insert_Topic 'ADO', '.NET Core'
Go

EXEC Assign_Course_to_Instructor @crs_name = 'CST', @ins_id = 1
GO
EXEC Assign_Course_to_Instructor @crs_name = 'CST', @ins_id =  2
GO
EXEC Assign_Course_to_Instructor @crs_name = 'CST', @ins_id =  3
GO
EXEC Assign_Course_to_Instructor @crs_name = 'CST', @ins_id = 4
GO
EXEC Assign_Course_to_Instructor @crs_name = 'CST', @ins_id = 5
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Advanced CST', @ins_id = 6
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Advanced CST', @ins_id = 7
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Advanced CST', @ins_id = 8
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Advanced CST', @ins_id = 9
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Advanced CST', @ins_id = 10
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 11
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 12
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 13
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 14
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 15
GO
EXEC Assign_Course_to_Instructor @crs_name = 'SQL', @ins_id = 16
GO
EXEC Assign_Course_to_Instructor @crs_name = '.NET Core', @ins_id = 17
GO
EXEC Assign_Course_to_Instructor @crs_name = '.NET Core', @ins_id = 18
GO
EXEC Assign_Course_to_Instructor @crs_name = '.NET Core', @ins_id = 19
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Programming Basics', @ins_id = 20
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Programming Basics', @ins_id = 21
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Programming Basics', @ins_id = 22
GO
EXEC Assign_Course_to_Instructor @crs_name = 'Programming Basics', @ins_id = 23
GO

/* ------------------------------------------------------------------------------- */
/*                             Course_Attendance                                   */
/* ------------------------------------------------------------------------------- */

Student_Take_course_with_Instructor 25 ,1400 , 17
GO
Student_Take_course_with_Instructor 26, 1300,  6
GO
Student_Take_course_with_Instructor 29, 1200,  2
GO
Student_Take_course_with_Instructor 32, 1000,  20
GO
Student_Take_course_with_Instructor 33, 1100,  11
GO

/* ------------------------------------------------------------------------------- */
/*                                 Question Table                                  */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*                                C Programming (top_id=10000)                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

EXEC insertMCQ 10000, 'Output for this piece of code is:
for(i<5;i=0;i++)
{
printf("%d",i);
}
If i is an integer and initialize to 1. What will be the output?',  '1234', '12345',
 '15',  'Nothing',  'd', @q_id OUTPUT

 GO

 DECLARE @q_id INT

EXEC insertMCQ 10000, 'Output for this piece of code is:
char *ch;
*ch= c ;
printf("%c",*ch);',  '1234', '12345',
 '15',  'Nothing',  'b', @q_id OUTPUT

 GO

/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

 DECLARE @q_id INT

 EXEC insertTFQ 10000, 'In C Programming language, any function can call any function except main it could not be called by any other function',
 'T', @q_id OUTPUT
 GO

 DECLARE @q_id INT

 EXEC insertTFQ 10000, 'Control always return to the caller when the function terminates normally',
 'T', @q_id OUTPUT
 GO

 DECLARE @q_id INT

 EXEC insertTFQ 10000, 'If you do not initialize an array of integers, the elements of that array will be set by zero values.',
 'F', @q_id OUTPUT
 GO

/* ------------------------------------------------------------------------------- */
/*                                C++ OOP (top_id=11000)                           */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertMCQ 11000, 'Which of the following access specifier is used as a default in a class definition?',  'Private', 'Public',
 'Friend',  'Protected',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 11000, 'Not using virtual destructor feature in a C++ object oriented programing can cause',  'An Issue in creating object of the class', 'Memory leak',
 'An issue in calling base class destructor',  'None of the above',  'B', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 11000, 'The order in which operands are evaluated in an expression is predictable if the operator is',  'Addition', 'Modulus',
 'Multiply',  '&&',  'D', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 11000, 'Which of the following is a mechanism of static polymorphism?',  'Templates', 'Function overloading',
 'Operator overloading',  'All of the above',  'D', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 11000, 'IS A relationship in C++ is',  'Inheritance', 'Encapsulation',
 'Composition',  'None of the above',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 11000, 'In a class, encapsulating an object of another class is called',  'Encapsulation', 'Inheritance',
 'Composition',  'None of the above',  'C', @q_id OUTPUT

GO

/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertTFQ 11000, 'It is not possible to achieve inheritance of structures in C++',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 11000, 'Super classes are also called Parent classes/Base classes.',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 11000, 'Sub classes may also be called Child classes/Derived classes.',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 11000, 'Constructors must have parameters.',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 11000, 'Objects cannot be created without applying the new operator.',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 11000, 'Overloaded methods are distinguished by their parameters.',
 'T', @q_id OUTPUT
GO

/* ------------------------------------------------------------------------------- */
/*                                  SWA (top_id=12000)                             */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertMCQ 12000, 'Which of these truly defines Software design?',  'Software design is an activity subjected to constraints', 'Software Design specifies nature and composition of software product',
 'Software Design satisfies client needs and desires',  'All of the mentioned',  'd', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 12000, 'What is incorrect about structural design?',  'Structural design introduced notations and heuristics', 'Structural design emphasis on procedural decomposition',
 'The advantage is data flow representation',  'It follows Structure chart',  'c', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 12000, 'Why does software engineering design shares many design principles?',  'Common design goal of creating high quality design', 'For expansion of product lifetime',
 'All of the mentioned',  'None of the mentioned',  'c', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 12000, 'Why are the design principles considered unique?',  'They are characteristic of well constructed programs', 'They are robust',
 'All of the mentioned',  'None of the mentioned',  'a', @q_id OUTPUT
GO

/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertTFQ 12000, 'Principle of feasibility states that a design is acceptable only when it is realized.',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 12000, 'Principle of adequacy states that Designs that make easier to change are better.',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 12000, 'A profile is a set of scenarios that are used to evaluate whether a product is likely to meet its requirements.',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 12000, 'Top down layer focuses on lower to higher abstraction.',
 'F', @q_id OUTPUT
GO

/* ------------------------------------------------------------------------------- */
/*                         Advanced Database (top_id=14000)                        */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertMCQ 14000, 'A trigger can be dropped using: ',  'DROP TRIGGER', 'ALTER TRIGGER DROP',
 'DEFINE DROP TRIGGER',  'DECLARE DROP TRIGGER',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 14000, 'Which of the following is true concerning a procedure?',  'You do not create them with SQL.', 'They do not need to have a unique name.',
 'They include procedural and SQL statements.',  'They are the same thing as a function.',  'C', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 14000, 'A CASE SQL statement is which of the following?',  'A way to establish an IF-THEN-ELSE in SQL.', 'A way to establish a loop in SQL.',
 'A way to establish a data definition in SQL.',  'All of the above.',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 14000, 'Which of the following is true concerning triggers?',  'You do not create them with SQL.', 'They execute against only some applications that access a database.',
 'They have an event, condition, and action.',  'They cannot cascade (cause another trigger to fire).',  'C', @q_id OUTPUT

GO

/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertTFQ 14000, 'ROLLBACK command makes the updates performed by the transaction permanent in the database?',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 14000, 'Indexes are synonyms of a column in a table.',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 14000, 'Index improves the speed of data retrieval operations on a table.',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 14000, 'Group of operations that form a single logical unit of work is known as transaction',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 14000, 'Shared locks are applied while performing write operations',
 'F', @q_id OUTPUT
GO

/* ------------------------------------------------------------------------------- */
/*							       HTML (top_id=15000)                             */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertMCQ 15000, 'HTML stands for: ',  'HighText Machine Language', 'HyperText and links Markup Language',
 'HyperText Markup Language',  'None of these',  'C', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'How to create a checkbox in HTML?',  '<input type = "checkbox">', '<input type = "button">',
 '<checkbox>',  '<input type = "check">',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'Which of the following element is responsible for making the text italic in HTML?',  '<i>', '<italic>',
 '<it>',  '<pre>',  'A', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'Which of the following tag is used to add rows in the table?',  '<td> and </td>', '<th> and </th>',
 '<tr> and </tr>',  'None of the above',  'C', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'The <hr> tag in HTML is used for -',  'new line', 'vertical ruler',
 'new paragraph',  'horizontal ruler',  'D', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'Which of the following attribute is used to provide a unique name to an element?',  'class', 'id',
 'type',  'None of the above',  'B', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'Which of the following is the container for <tr>, <th>, and <td> ?',  '<data>', '<table>',
 '<group>',  'All of the above',  'B', @q_id OUTPUT

GO

DECLARE @q_id INT
EXEC insertMCQ 15000, 'How to insert a background image in HTML?',  '<body background = "img.png">', '<img background = "img.png">',
 '<bg-image = "img.png">',  'None of the above',  'A', @q_id OUTPUT

GO


/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertTFQ 15000, 'type is an HTML attribute is used to define inline styles',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 15000, '<b> is the paragraph tag in HTML',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 15000, 'In HTML5 <!DOCTYPE html> is used to initialize the document type',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 15000, '<select> is used to create a combo box (or drop-down box)',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 15000, '<select> is used to create a combo box (or drop-down box)',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 15000, '<mail xy@y</mail> can be used to send a mail in HTML',
 'F', @q_id OUTPUT
GO

/* ------------------------------------------------------------------------------- */
/*							       ADO (top_id=22000)                              */
/* ------------------------------------------------------------------------------- */

/* ------------------------------------------------------------------------------- */
/*									       MCQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertMCQ 22000, 'To use the .NET Framework Data Provider for SQL Server, an application must reference the _____________ namespace.',  'System.Data.Client', 'System.Data.SqlClient',
 'System.Data.Sql',  'None of the mentioned',  'B', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 22000, 'Code snippet for having a named instance of SQL Server would be',  '�Server=localhost\sqlexpress�', '�Server=local\sqlexpress�',
 '�Server=host\sqlexpress�',  '�Ser=localhost\sqlexpress�',  'A', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 22000, 'Which of the following is enumeration for ADO.net with SQL Server?',  'SqlInfo', 'SqlBulkCopyOptions',
 'SqlNotification',  'All of the mentioned',  'B', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 22000, 'To perform asynchronous data access, what must be added to the connection string?',  'BeginExecute=true', 'MultiThreaded=true',
 'MultipleActiveResultSets=true',  'Asynchronous=true',  'D', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 22000, 'Which is a property of the DataGrid control?',  'DataMember', 'DataSource',
 'DataQuery',  'All of the above.',  'D', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertMCQ 22000, 'In a connection string _____________ represents name of the database',  'Data Source', 'Initial Catalog',
 'Catalog Initial',  'Database',  'B', @q_id OUTPUT
GO


/* ------------------------------------------------------------------------------- */
/*									       TFQ                                     */
/* ------------------------------------------------------------------------------- */

DECLARE @q_id INT
EXEC insertTFQ 22000, 'The first record in a dataset has a position property of zero',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 22000, 'DataSet is a class in ADO.net class which provides a disconnected environment',
 'T', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 22000, 'The ADO.NET SqlConnection object designed for MySQL',
 'F', @q_id OUTPUT
GO

DECLARE @q_id INT
EXEC insertTFQ 22000, 'The first step of configuring a DataAdapter is to select a dataset object',
 'F', @q_id OUTPUT
GO
Assign_Course_to_Instructor 'Programming Basics', 23

GO
Student_Take_course_with_Instructor 25 ,1400 , 1
GO
Student_Take_course_with_Instructor 26, 1300,  6
GO
Student_Take_course_with_Instructor 29, 1200,  2
GO
Student_Take_course_with_Instructor 32, 1000,  20
GO
Student_Take_course_with_Instructor 33, 1100,  11
GO

--------------- TF (C Language Topic) ---------------------

GO
declare @que_id int
execute insertTFQ 10000, 'Does C language support OOP concept?', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'IS there keywords for printing ans scanning inputs in c?', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'C language is platform dependant?', 'T', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'IS pointer to pointer to char like two-dimensional array of characters', 'T', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'Struct is a user defined data type in C?', 'T', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'Should we need to redeclare functions in header files before using it?', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 10000, 'switch case must be int or any data type that implicitly map to int?', 'T', @que_id output
GO

--------------- MCQ (C Language Topic) ---------------------

GO
declare @que_id int
execute insertMCQ 10000, 'how to declare a pointer to an integer in C?', 'int P*', 'int * ptr', 'integer pointer x', 'int &x', 'b', @que_id output

GO
declare @que_id int
execute insertMCQ 10000, 'a function used to allocate memory in heap in c?', 'getMemory()', 'NEW keyword', 'malloc()', 'free()', 'c', @que_id output
GO
declare @que_id int
execute insertMCQ 10000, 'a function used to deallocate memory from heap in C?', 'free()', 'delete keyword', 'letMemory()', 'realloc()', 'a', @que_id output

GO
declare @que_id int
execute insertMCQ 10000, 'which is responsible to push and pop stack frames from stack?', 'Operating System', 'developer', 'push and pop functions', 'compiler', 'a', @que_id output

GO
declare @que_id int
execute insertMCQ 10000, 'Which of the following are correct ways to refer to the variable ch, assuming
the address of ch has been assigned to the pointer fingerch?', '*ch;', '*finger;', 'int *fingerch;', '* fingerch;', 'd', @que_id output

GO
declare @que_id int
execute insertMCQ 10000, 'Which of the following is best suited for representing a Matrix with 3 Rows
and 3 Columns?', 'One-Dimensional Array', 'Two-Dimensional Array', 'Three-Dimensional Array', 'All of the above', 'b', @que_id output

GO
declare @que_id int
execute insertMCQ 10000, 'What does the following program segment do?
int numb;
do {
scanf(“%d”, &numb);
} while (numb < 1 && numb > 10);', 'Reads an integer in the range [1, 10]', 'Reads an integer out of range [1, 10]', 'Reads an integer other than 1 and 10', 'Non of the above', 'd', @que_id output
GO

declare @que_id int
execute insertMCQ 10000, 'In the array below, how can you access the element which has the value 4:
int  arr[3][3]={ {1,2,3}, {4,5,6}, {7,8,9} };', 'arr[0][0]', 'arr[0][1]', 'arr[1][0] ', 'arr[1][1]', 'c', @que_id output
GO

declare @que_id int
execute insertMCQ 10000, 'The key of ....... is that you have to determine if you are dealing with the data or you are dealing with the address of data', 'Structure', 'Pointers', 'Stack', 'Binary Search Tree', 'b', @que_id output
GO

declare @que_id int
execute insertMCQ 10000, 'An array is a collection of variables of:', 'Different data types scattered throughout memory', 'The same data type scattered throughout memory',
'The same data type placed next to each other in memory', 'Different data types placed next to each other in memory', 'c', @que_id output
GO

declare @que_id int
execute insertMCQ 10000, 'You have the following piece of code:
int x = 0 , y = 4;
while ( x < 11){
     y --;
     x + = 2 * y;} when the loop has finished the value of x is :' , '1', '12', '13', '14', 'b', @que_id output
GO

/* ------------------------------------------------------------------------------- */
/*                                   Question Table                                */
/* ------------------------------------------------------------------------------- */

-- CSS Topic 1600
-- insertMCQ @top_id, @q_text, @ch_a, @ch_b, @ch_c ,@ch_d , @corr_answer , @q_id int output
declare @q_id int
Execute insertMCQ 16000,
	'What does CSS stand for?', 
	'Cascade Style Sheet', 
	'Common Style Sheet',
	'Cascade Separate Sheet',
	'Nothing from the above',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How can you created rounded corners using CSS3?', 
	'border[round]: 30px;', 
	'corner-effect: round;',
	'border-radius: 30px;',
	'alpha-effect: round-corner;',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How do you add shadow to elements in CSS3?', 
	'box-shadow: 10px 10px 5px grey;', 
	'shadow-right: 10px shadow-bottom: 10px;',
	'shadow-color: grey;',
	'alpha-effect[shadow]: 10px 10px 5px grey;',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to you modify a border image using CSS3?', 
	'border: url(image.png);', 
	'border-variable: image url(image.png);',
	'border-image: url(border.png) 30 30 round;',
	'None',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to resize a background image using CSS3?', 
	'background-size: 80px 60px;', 
	'bg-dimensions: 80px 60px;',
	'background-proportion: 80px 60px;',
	'None',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to add text shadow using CSS3?', 
	'font: shadowed 5px 5px 5px grey;', 
	'font-shadow: 5px 5px 5px grey;',
	'text-shadow: 5px 5px 5px grey;',
	'None',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to force a word wrap using CSS3?', 
	'word-wrap: break-word;', 
	'text-wrap: break-word;',
	'text-wrap: force;',
	'None',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'Which of these are valid CSS3 transformation statements', 
	'matrix()', 
	'modify()',
	'skip()',
	'simulate()',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to rotate objects using CSS3?', 
	'object-rotation: 30deg;', 
	'transform: rotate(30deg);',
	'rotate-object: 30deg;',
	'transform: rotate-30deg-clockwise;',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to create transition effects using CSS3?', 
	'transition: width 2s;', 
	'transition-duration: 2s; transition-effect: width;',
	'alpha-effect: transition (width,2s);',
	'None',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 16000,
	'How to you modify a border image using CSS3?', 
	'border: url(image.png);', 
	'border: image url(image.png);',
	'border-image: url(border.png) 30 30 round;',
	'None',
	'c',
	@q_id output

go

-----------------------------------------
-- Insert TFQ
declare @q_id int
Execute insertTFQ 16000,
	'Linking to an external style sheet allows you to have hyperlinks from your page to the World Wide Web.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'The link element should be placed at the top of the body section.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'The MIME type for a CSS style sheet is "stylesheet = CSS".', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'The rel attribute specifies a relationship between the current document and another document, such as a style sheet.', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'Specifying an element position as absolute removes it from the normal flow of elements on the page.', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'Relative positioning removes elements from the general flow of elements on the page.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 16000,
	'The span element applies a class to a portion of text without the need for a new line.', 
	'T',
	@q_id output

go

------------------------------------------------
-- Javascript 17000

-- MCQ

declare @q_id int
Execute insertMCQ 17000,
	'What is JavaScript?', 
	'JavaScript is a scripting language used to make the website interactive', 
	'JavaScript is an assembly language used to make the website interactive',
	'JavaScript is a compiled language used to make the website interactive',
	'None of the mentioned',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Which of the following is correct about JavaScript?', 
	'JavaScript is an Object-Based language', 
	'JavaScript is Assembly-language',
	'JavaScript is an Object-Oriented language',
	'JavaScript is a High-level language',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Among the given statements, which statement defines closures in JavaScript?', 
	'JavaScript is a function that is enclosed with references to its inner function scope', 
	'JavaScript is a function that is enclosed with references to its lexical environment',
	'JavaScript is a function that is enclosed with the object to its inner function scope',
	'None of the mentioned',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'What will be the output of the following JavaScript code?
	<p id="demo"></p>
	<script>
	var js = 10;
	js *= 5;
	document.getElementById("demo").innerHTML = js;
	</script>', 
	'10', 
	'50',
	'5',
	'Error',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'What will be the output of the following JavaScript code snippet?
	<p id="demo"></p>
	var txt1 = "Sanfoundry_";
	var txt2 = "Javascriptmcq";
	document.getElementById("demo").innerHTML = txt1 + txt2;', 
	'error', 
	'Sanfoundry_ Javascriptmcq',
	'undefined',
	'Sanfoundry_Javascriptmcq',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Arrays in JavaScript are defined by which of the following statements?', 
	'It is an ordered list of values', 
	'It is an ordered list of objects',
	'It is an ordered list of string',
	'It is an ordered list of functions',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'What will be the output of the following JavaScript code?
	// JavaScript Comparison Operators
	function compare()
	{
		int num=2;
		char b=2;
		if(a==b)
			return true;
		else
			return false;
	}', 
	'false', 
	'true',
	'compilation error',
	'runtime error',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'What will be the output of the following JavaScript code snippet?
	// JavaScript Equalto Operators
	function equalto()
	{
		int num=10;
		if(num===”10”)
			return true;
		else
			return false;
	}', 
	'false', 
	'true',
	'compilation error',
	'runtime error',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Will the following JavaScript code work?
	var js = (function(x) {return x*x;}(10));', 
	'Exception will be thrown', 
	'Memory leak',
	'Error',
	'Yes, perfectly',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Which of the following is not javascript data types?', 
	'Null type', 
	'Undefined type',
	'Number type',
	'All of the mentioned',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 17000,
	'Where is Client-side JavaScript code is embedded within HTML documents?', 
	'A URL that uses the special javascript:code', 
	'A URL that uses the special javascript:protocol',
	'A URL that uses the special javascript:encoding',
	'A URL that uses the special javascript:stack',
	'b',
	@q_id output

go


-- TFQ

declare @q_id int
Execute insertTFQ 17000,
	'If you type the following code in the console window, what result will you get?
	3 > 2 > 1 === false;', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'JavaScript is a client-side programming language.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'You can find the minimum of x and y using min(x,y);', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'This statement will throw an error
	var fun = function bar{ }', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'default is a JavaScript label that catches all the values, except for the ones specified', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'if(x = 2) is a valid statement to execute certain code if “x” is equal to 2', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 17000,
	'What will the code return?
	Boolean(3 < 7)', 
	'T',
	@q_id output

go


------------------------------------------------
-- Advanced Javascript 18000

-- MCQ

declare @q_id int
Execute insertMCQ 18000,
	'Can a JavaScript constructor return a primitive value (e.g. a number or a string)?', 
	'Only in Constructor', 
	'Yes',
	'Only in a function',
	'No',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'Which method is called when all the page elements have loaded(HTML, CSS, images)?', 
	'window.laoded()', 
	'window.ondelay()',
	'window.delay()',
	'window.onload()',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'Among the given statements, which statement defines closures in JavaScript?', 
	'JavaScript is a function that is enclosed with references to its inner function scope', 
	'JavaScript is a function that is enclosed with references to its lexical environment',
	'JavaScript is a function that is enclosed with the object to its inner function scope',
	'None of the mentioned',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'Once you create an object, can we add, remove or change properties of that object at any time?', 
	'Yes', 
	'No',
	'For some objects',
	'For inherited objects',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'Which of the following is the best example of automatic type conversion in JavaScript?', 
	'"5" + cats = "5 cats"',
	'"5" + "cats" = "5 cats"',
	'"5" + cats = 5 cats',
	'5 + "cats" = "5 cats"',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'What is the name of the property that allows you to add properties and methods to an object?', 
	'The "prototype" property', 
	'The "public" property',
	'The "protected" property',
	'The "private" property',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'What does the “this” keyword refer to in a function of a class?', 
	'To that function.', 
	'To the object that a function is a method of.',
	'To the Class.',
	'None of these.',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'What will be the output of the following line in JavaScript?
	"1"+2+3', 
	'123', 
	'15',
	'14',
	'23',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'What you have to instantiate first with constructor functions?', 
	'class', 
	'none of these',
	'object',
	'function',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 18000,
	'In JavaScript, addEvent is a combination of __________ function?', 
	'None of these', 
	'Event() and addEventListener()',
	'addEventListener() and attachEvent() function',
	'addEventListener()',
	'c',
	@q_id output

go



-- TFQ

declare @q_id int
Execute insertTFQ 18000,
	'VARCHAR datatype is not supported in Javascript?', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'console.log((function f(n){return ((n > 1) ? n * f(n-1) : n)})(10));
	The output will be the factorial of 10?', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'NaN is a Number', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'Custom Dialog popup box cannot be created in Javascript', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'JavaScript constructor can return a primitive value (e.g. a number or a string)?', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'Unobtrusive Javascript is basically a JavaScript methodology 
	that seeks to overcome browser inconsistencies by separating page 
	functionality from structure.', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 18000,
	'(function(x) {
		return (function(y) {
			console.log(x);
		})(2)
	})(1);
	The output of this code is: 1', 
	'T',
	@q_id output

go


------------------------------------------------
-- HTML5 19000

-- MCQ

declare @q_id int
Execute insertMCQ 19000,
	'____________tag is used to specify an inline frame', 
	'<jframe>', 
	'<frameset>',
	'<iframe>',
	'<frame>',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'What is mean by DTD?', 
	'Document type data', 
	'Data type definition',
	'Document type definition',
	'Definition type document',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'How many graphic object types are allowed by SVG?', 
	'2', 
	'3',
	'5',
	'7',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'<canvas > element is only a ____________to the graphics.', 
	'component', 
	'container',
	'attribute',
	'method',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'HTML is based on which language?', 
	'XHTML',
	'XML',
	'SGML',
	'DTD',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'The following code is used for:
	&lt;video width=“320″ height=“240″ controls=“controls”&gt; <br />&lt;source src=“test.mp4″ type=“video/mp4″ /&gt; <br />&lt;/video&gt;', 
	'Display audio', 
	'Display video ',
	'Display text',
	'None',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'The __________ is an instruction to the web browser about what version of HTML the page is written in', 
	'<!DOCTYPE>', 
	'<DOCTYPE>',
	'<!TYPE>',
	'None of these.',
	'a',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'DHTML is the combination of
		1)HTML
		2)javascript
		3)HTML  Dom
		4)CSS', 
	'1 and 2', 
	'3 and 4',
	'all of the above',
	'none of these',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'Ancestor of all other elements on the page is called________', 
	'parent', 
	'ancestor',
	'root element',
	'siblings',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 19000,
	'Canvas is able to draw the 2D graphics using---------------', 
	'XML', 
	'HTML',
	'Javascript',
	'XHTML',
	'c',
	@q_id output

go



-- TFQ

declare @q_id int
Execute insertTFQ 19000,
	'W3C stands for World Wide Web Consortium', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'SVG means scalable vertical graphics', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'Attributes consist of a name and a value separated by ; sign', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'It is possible to use HTML 5 for the mobile application', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'The sessionStorage object stores the data for multible sessions', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'Graphics defined by SVG is in DTD format.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'If background image is smaller than the screen, It will be repeated', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 19000,
	'In the Article element, both start and end tag are required.', 
	'F',
	@q_id output

go


------------------------------------------------
-- C# 20000

-- MCQ

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following is correct about C#?', 
	'C# is a modern, general-purpose, object-oriented programming language developed by Microsoft.', 
	'C# was developed by Anders Hejlsberg and his team during the development of .Net Framework.',
	'C# is designed for Common Language Infrastructure (CLI).',
	'All of the above',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following defines unboxing correctly?', 
	'When a value type is converted to object type, it is called unboxing.', 
	'When an object type is converted to a value type, it is called unboxing.',
	'Both of the above.',
	'None of the above.',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following converts a type to a 32-bit integer in C#?', 
	'ToDecimal', 
	'ToDouble',
	'ToInt16',
	'ToInt32',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following operator determines whether an object is of a certain type in C#?', 
	'?:', 
	'is',
	'as',
	'*',
	'b',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following statements is correct about encapsulation?', 
	'Encapsulation is defined as the process of enclosing one or more items within a physical or logical package.',
	'Encapsulation, in object oriented programming methodology, prevents access to implementation details.',
	'Abstraction allows making relevant information visible and encapsulation enables a programmer to implement the desired level of abstraction.',
	'All of the above.',
	'd',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following is the correct about interfaces in C#?', 
	'Interfaces are declared using the interface keyword.', 
	'Interface methods are public by default.',
	'Both of the above.',
	'None of the above',
	'c',
	@q_id output

go

declare @q_id int
Execute insertMCQ 20000,
	'Which of the following preprocessor directive specifies the end of a conditional directive in C#?', 
	'elif', 
	'endif',
	'else',
	'if',
	'b',
	@q_id output

go

-- TFQ

declare @q_id int
Execute insertTFQ 20000,
	'The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'Arithmetic operators are called binary operators when you use two arguments with each operator', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'Reference and output parameters have memory addresses that are passed to a method, allowing it to alter the original variables.', 
	'T',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'The WriteLine() method returns a string that holds the name of the class, just as GetType() does', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'In C#, you can use either new or out when defining a derived class member that has the same name as a base class member.', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'The data components of a class often are called its iteration', 
	'F',
	@q_id output

go

declare @q_id int
Execute insertTFQ 20000,
	'In C#, you can display variable values by using the variable name within a WriteLine() method call.', 
	'T',
	@q_id output

go
--------------- TF (DB Topic) ---------------------

declare @que_id int
execute insertTFQ 13000, 'In a sub-query, the inner query executes first, and once, before the outer query', 'T', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'There are physical records corresponding to user created views.', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'Relational data base relation may accept multi-valued data items (attributes)', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'Deleting all tuples of a table is equivalent to dropping it.', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'In a table the records are ordered top to bottom.', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'SQL language has data definition statements such as INSERT, UPDATE, DELETE and data manipulation statements such as CREATE.', 'F', @que_id output
GO
declare @que_id int
execute insertTFQ 13000, 'Two distinct tuples cannot have identical values in all fields that comprise a primary key', 'T', @que_id output
GO

--------------- MCQ (DB Topic) ---------------------

GO
declare @que_id int
execute insertMCQ 13000, 'How many primary keys can a table have?', 'One', 'At least one, but not more than two', 'Between one and five', 'No limit', 'a', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'An attribute that can be broken down into smaller parts is called', 'simple', 'composite', 'associative', 'none of the above', 'b', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'To get all the rows from the students table, which of the following SQL
Statements should be used?', 'Select * from Students where name= none group by name.', 'Select * from Students.', 'Select * from Students where name= A or B Group by name.', 'None of the above.', 'b', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'What does an RDBMS consist of?', 'Collection of Records', 'Collection of Keys', 'Collection of Fields', 'Collection of Tables', 'd', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'What is information about data called?', 'Relations', 'Hyper data', 'Meta data', 'Tera data', 'c', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'The ability to query data, as well as insert, delete, and alter tuples, is offered by ', 'TCL', 'DCL', 'DDL', 'DML', 'd', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'Which of the following is known as a set of entities of the same type that share same properties, or attributes?', 'Relation set', 'Tuples', 'Entity set', 'Entity Relation model', 'c', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, '....... is a set of one or more attributes taken collectively to uniquely identify a record', 'Super key', 'Primary Key', 'Candidate key', 'Foreign key', 'a', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'Which command is used to remove a relation from an SQL?', 'Drop table', 'Delete', 'Purge', 'Remove', 'a', @que_id output

GO
declare @que_id int
execute insertMCQ 13000, 'Which of the following set should be associated with weak entity set for weak entity to be meaningful?', 'Neighbour set', 'Strong entity set', 'Owner set', 'Identifying set', 'd', @que_id output



---------------------------------- exams --------------------------------- 
declare @exam_id1 int
declare @exam_id2 int
declare @exam_id3 int

-- Student_Take_course_with_Instructor 25 ,1400 , 17
EXEC generateExam "Advanced CST" , 26 , @exam_id1 output
EXEC generateExam "CST" , 29 , @exam_id2 output
EXEC generateExam "Programming Basics" , 32 , @exam_id3 output


exec answerExam 26 , @exam_id1 , "a" , "c" , "b" , "d" , "d" ,
							 	 "a" , "c" , "d" , "b" , "c"

EXEC answerExam 29 , @exam_id2 , "b" , "c" , "a" , "d" , "d" ,
							 	 "c" , "b" , "d" , "a" , "c"

EXEC answerExam 32 , @exam_id3 , "d" , "c" , "a" , "b" , "d" ,
							 	 "c" , "b" , "d" , "a" , "c"
