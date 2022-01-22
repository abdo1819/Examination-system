

/* -------------------------------------------------------------------------- */
/*                                  POPULATE DB                               */
/* -------------------------------------------------------------------------- */

USE EXAMINATION


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

 EXEC insertTFQ 10000, 'If you don’t initialize an array of integers, the elements of that array will be set by zero values.',
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
EXEC insertTFQ 11000, 'It is not possible to achieve inheritance of structures in c++',
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


