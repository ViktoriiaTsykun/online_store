using OnlineShop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Categories.Any())
            {
                content.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Manufacturers.Any())
            {
                content.Manufacturers.AddRange(Manufacturers.Select(p => p.Value));
            }

            if (!content.Products.Any())
            {
                content.Products.AddRange(Products.Select(p => p.Value));
            }

            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Комп'ютери", description = "Електронні пристрої, які призначені для автоматизованої обробки інформації у формі, зручній для користувача."},
                        new Category { categoryName = "Ноутбуки", description = "Портативні персональні комп'ютери, що відрізняються невеликими розмірами і вагою."},
                        new Category { categoryName = "Смартфони", description = "Мобільні телефони, які доповнені функціональністю кишенькового персонального комп'ютера."},
                        new Category { categoryName = "Планшети", description = "Електронні пристрої з сенсорним екраном, що дозволяють управляти комп'ютерними програмами, через дотик пальцями до об'єктів програми на екрані."},
                        new Category { categoryName = "Телевізори", description = "Пристрої, які призначені для демонстрації нерухомих і рухомих зображень із звуковим супроводом."},
                        new Category { categoryName = "Фотоапарати", description = "Пристрої для отримання фотографій."},
                        new Category { categoryName = "Відеокамери", description = "Мініатюрні ручні телекамери, призначені для запису відео."},
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }

                return category;
            }
        }

        private static Dictionary<string, Manufacturer> manufacturer;

        public static Dictionary<string, Manufacturer> Manufacturers
        {
            get
            {
                if (manufacturer == null)
                {
                    var list = new Manufacturer[]
                    {
                        new Manufacturer { manufacturerName = "Apple", description = "Американська технологічна компанія, яка проектує та розробляє побутову електроніку, програмне забезпечення та онлайн-сервіси."},
                        new Manufacturer { manufacturerName = "Acer", description = "Тайванська компанія з виробництва комп'ютерної техніки та електроніки."},
                        new Manufacturer { manufacturerName = "Asus", description = "Тайванська міжнародна компанія, що виробляє материнські плати, відеокарти, монітори, ноутбуки, мобільні телефони."},
                        new Manufacturer { manufacturerName = "Canon", description = "Японська корпорація, що створює цифрове обладнання для користувачів."},
                        new Manufacturer { manufacturerName = "Dell", description = "Американська компанія, один із світових лідерів в галузі розробки і виробництва комп'ютерних систем."},
                        new Manufacturer { manufacturerName = "Huawei", description = "Китайська компанія у сфері телекомунікацій."},
                        new Manufacturer { manufacturerName = "Nikon", description = "Японська компанія, що спеціалізується на виробництві оптики, оптичних приладів та електронних пристроїв для обробки зображень."},
                        new Manufacturer { manufacturerName = "Samsung", description = "Південнокорейська транснаціональна компанія-конгломера, Samsung Electronics - найбільша на планеті компанія з виробництва інформаційних технологій."},
                        new Manufacturer { manufacturerName = "Sony", description = "Японська транснаціональна корпорація, що займається випуском побутової та професійної електроніки та іншої високотехнологічної продукції."},
                        new Manufacturer { manufacturerName = "Xiaomi", description = "Китайська компанія, що спеціалізується на виробництві електронної техніки, в першу чергу смартфонів та інших \"розумних пристроїв\"."},
                    };

                    manufacturer = new Dictionary<string, Manufacturer>();
                    foreach (Manufacturer el in list)
                    {
                        manufacturer.Add(el.manufacturerName, el);
                    }
                }

                return manufacturer;
            }
        }


        private static Dictionary<string, Product> product;

        public static Dictionary<string, Product> Products
        {
            get
            {
                if (product == null)
                {
                    var list = new Product[]
                    {
                        new Product {
                            name = "Vostro 3470 v09 (3470v09)",
                            shortDescr = "Intel Core i5-9400 (2.9 — 4.1 ГГц) / RAM 16 ГБ / HDD 1 ТБ + SSD 480 ГБ / Intel UHD Graphics 630 / DVD-RW / LAN / Wi-Fi / без ОС",
                            longDescr = "Персональні комп'ютери Dell Vostro 3470 поєднують у собі всі переваги сучасних комп'ютерів у корпусі Mini-Tower і мають водночас масу просунутих можливостей. Використовуючи перевірену компонентну базу від іменитого бренда Dell як основу, Artline доповнили та розширили її можливості, створивши зразковий комп'ютер, який втілив усе, що ви чекаєте від такого продукту: продуктивність, надійність, довговічність, простоту обслуговування й економність, що дасть змогу істотно мінімізувати операційні витрати.",
                            img = "/img/computers/dell1.jpg",
                            price = 17994,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Комп'ютери"],
                            Manufacturer = Manufacturers["Dell"]
                        },
                        new Product {
                            name = "OptiPlex 3060 SFF (210-AOIMi3Uv01)",
                            shortDescr = "Intel Core i5-8400 (2.8 — 4.0 ГГц)/RAM 8 ГБ/SSD 128 ГБ/Intel UHD Graphics 630/без ОД/LAN/Linux/клавіатура + миша",
                            longDescr = "Dell OptiPlex 3060 — це надкомпактний настільний комп'ютер для бізнесу з різноманітними варіантами кріплення, придатними для будь-якої робочого середовища. Підтримує функції захисту й керування світового класу.",
                            img = "/img/computers/dell2.jpg",
                            price = 12999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Комп'ютери"],
                            Manufacturer = Manufacturers["Dell"]
                        },
                        new Product {
                            name = "Veriton S2660G (DT.VQXME.007)",
                            shortDescr = "Intel Core i5-8400 (2.8 - 4.0 ГГц) / RAM 8 ГБ / HDD 1 ТБ / Intel UHD Graphics 630 / без ОД / LAN / Endless OS",
                            longDescr = "Більше — краще. Завдяки твердотільним накопичувачам, підтримці під'єднання 2 моніторів і зручному для розширення корпусу ви зможете працювати краще на цьому настільному ПК.",
                            img = "/img/computers/acer1.jpg",
                            price = 9999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Комп'ютери"],
                            Manufacturer = Manufacturers["Acer"]
                        },
                        new Product {
                            name = "Vivo AiO V222UAK-BA150D Black (90PT0261-M07820)",
                            shortDescr = "Екран 21.5\" (1920x1080) IPS/Intel Pentium Gold 4417U (2.3 ГГц)/RAM 4 ГБ/SSD 256 ГБ/Intel HD Graphics 610/без ОД/LAN/Wi-Fi/Bluetooth/вебкамера/Endless OS/4.84 кг/чорний",
                            longDescr = "Витончений комп'ютер з оптимізованою аудіосистемою Vivo AiO V222 — це одна з найтонших моделей у лінійці моноблокових комп'ютерів Vivo AiO. Вона буде особливо доброю для мультимедійних застосунків, оскільки містить високоякісну вбудовану аудіосистему, яка видає потужний звук із мінімальним рівнем спотворень.",
                            img = "/img/computers/asus1.jpg",
                            price = 12072,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Комп'ютери"],
                            Manufacturer = Manufacturers["Asus"]
                        },
                        new Product {
                            name = "iMac 21.5\" A1418 (MMQA2UA/A)",
                            shortDescr = "Екран 21.5\" IPS (1920x1080) LED / Intel Core i5 (2.3 - 3.6 ГГц) / RAM 8 ГБ / HDD 1 ТБ / Intel Iris Plus Graphics 640 / без ОД / LAN / Wi-Fi / Bluetooth / кардридер / веб-камера / macOS Sierra / 5.66 кг / сріблястий / клавіатура + миша",
                            longDescr = "iMac. Найясніший погляд на речі.Настільний комп'ютер, який занурює вас у контент. Буквально. Ця ідея лежить в основі сучасного iMac — і сьогодні вона актуальна, як ніколи. Абсолютно новий процесор, інноваційні графічні технології, передовий накопичувач і роз'єми з приголомшливою пропускною здатністю — все це новий iMac. Працювати на iMac тепер ще цікавіше та цікавіше.",
                            img = "/img/computers/apple1.jpg",
                            price = 36499,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Комп'ютери"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "Mi Notebook Air 13.3\" (JYU4051) Grey",
                            shortDescr = "Екран 13.3\" IPS (1920x1080) Full HD, глянсовий / Intel Core i7-8550U (1.8 — 4.0 ГГц) / RAM 8 ГБ / SSD 256 ГБ / nVidia GeForce MX150, 2 ГБ / без ОД / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64bit / 1.28 кг / темно-сірий",
                            longDescr = "Mi Notebook Air — перший ноутбук від китайської компанії Xiaomi. Корпус має стильний, дорогий вигляд і залишає приємні відчуття під час роботи. Він виготовлений з алюмінію, скла та високоякісного пластику. Модель зібрана ідеально, не має зазорів і працює тихо.",
                            img = "/img/laptops/xiaomi1.jpg",
                            price = 26499,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Xiaomi"]
                        },
                        new Product {
                            name = "Mi Notebook Lite 15.6\" (JYU4083CN) Black",
                            shortDescr = "Екран 15.6\" IPS (1920x1080) Full HD, глянсовий / Intel Core i5-8250U (1.6 — 3.4 ГГц) / RAM 8 ГБ / HDD 1 ТБ + SSD 128 ГБ / nVidia GeForce MX110, 2 ГБ / без ОД / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64bit / 2.18 кг / чорний",
                            longDescr = "Notebook Lite виводить продуктивність 15.6-дюймового ноутбука на абсолютно новий рівень. Нове 8-е покоління процесорів Intel Core, вдосконалена система охолодження, високошвидкісна пам'ять і твердотілий накопичувач.",
                            img = "/img/laptops/xiaomi2.jpg",
                            price = 24499,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Xiaomi"]
                        },
                        new Product {
                            name = "Inspiron 3582 (I35C445DIW-73B) Black",
                            shortDescr = "Екран 15.6\" TN+film (1366x768) WXGA HD, глянсовий з антивідблисковим покриттям / Intel Celeron N4000 (1.1 — 2.6 ГГц) / RAM 4 ГБ / HDD 500 ГБ / Intel UHD 600 / DVD+/-RW / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64bit / 2.28 кг / чорний",
                            longDescr = "Універсальний 15.6-дюймовий ноутбук за доступною ціною Dell Inspiron 3582, обладнаний розважальними можливостями, які забезпечують чудову якість відтворення мультимедійних матеріалів.",
                            img = "/img/laptops/dell1.jpg",
                            price = 6699,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Dell"]
                        },
                        new Product {
                            name = "Gaming X571GT-BN436 (90NB0NL1-M07160) Star Black",
                            shortDescr = "Екран 15.6\" IPS (1920x1080) Full HD, матовий / Intel Core i5-8300H (2.3 — 4.0 ГГц) / RAM 8 ГБ / SSD 256 ГБ / nVidia GeForce GTX 1650, 4 ГБ / без ОД / LAN / Wi-Fi / Bluetooth / вебкамера / без ОС / 2.14 кг / чорний",
                            longDescr = "Якість та стиль. Asus X571GT може працювати бездоганно і мати гарний вигляд. Переконайтеся в цьому самі, познайомившись із ноутбуком Asus X571GT. Сучасна начинка забезпечує X571GT неабияку продуктивність, а завдяки стильному та легкому корпусу цей ноутбук легко взяти із собою в дорогу.",
                            img = "/img/laptops/asus1.jpg",
                            price = 20999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Asus"]
                        },
                        new Product {
                            name = "MacBook Pro 13\" A2289 Retina 512GB 2020 (MXK72UA/A) Silver",
                            shortDescr = "Екран 13.3\" IPS (2560x1600), глянсовий / Intel Core i5-8257U (1.4 — 3.9 ГГц) / RAM 8 ГБ / SSD 512 ГБ / Intel Iris Plus Graphics 645 / Wi-Fi / Bluetooth / macOS Catalina / 1.4 кг / сріблястий",
                            longDescr = "Це MacBook Pro з 4-ядерним процесором Intel і клавіатурою Magic Keyboard. Він має все для роботи на вищому рівні. MacBook Pro обладнаний 4-ядерним процесором Intel, завдяки чому продуктивність стала вищою до 90%.",
                            img = "/img/laptops/apple1.jpg",
                            price = 48999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "Swift 3 SF314-41-R1EL (NX.HFDEU.006) Sparkly Silver",
                            shortDescr = "Екран 14\" IPS (1920x1080) Full HD, матовий / AMD Athlon 300U (2.4 — 3.3 ГГц) / RAM 8 ГБ / SSD 256 ГБ / AMD Radeon Vega 3 / без ОД / Wi-Fi / Bluetooth / вебкамера / без ОС / 1.5 кг / сріблястий",
                            longDescr = "Swift 3 це не звичайний ноутбук, а незамінний помічник, з яким ви не зможете розлучитися ані на хвилину! Адже справи з ним йдуть на лад, а розваги стають ще цікавішими! Пристрій в ультратонкому корпусі зручно брати із собою куди завгодно, а поміщені в ньому технології забезпечують усі цифрові можливості, необхідні сучасній людині.",
                            img = "/img/laptops/acer1.jpg",
                            price = 12999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Acer"]
                        },
                        new Product {
                            name = "Inspiron 3583 (I3583F38S2NW-8BK) Black",
                            shortDescr = "Екран 15.6\" (1920x1080) Full HD, глянсовий з антивідблисковим покриттям / Intel Core i3-8145U (2.1 — 3.9 ГГц) / RAM 8 ГБ / SSD 256 ГБ / Intel HD Graphics 620 / без ОД / LAN / Wi-Fi / Bluetooth / вебкамера / Windows 10 Home 64bit Ukr / 2.18 кг / чорний",
                            longDescr = "Ноутбук Dell Inspiron 3583 — це прекрасна робоча конячка. Він ідеально пасуватиме як для роботи, так і для навчання. Технічні характеристики пристрою дають йому змогу справлятися із завданнями будь-якої складності. Доступна ціна ноутбука Dell Inspiron 3583 робить його прекрасним варіантом для щоденного використання, а компактні розміри та невелика вага забезпечать максимум зручності, коли ви будете брати його із собою.",
                            img = "/img/laptops/dell2.jpg",
                            price = 14799,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Dell"]
                        },
                        new Product {
                            name = "MacBook Pro 13\" Retina 128GB 2019 (MUHN2UA/A) Space Gray",
                            shortDescr = "Екран 13.3\" IPS (2560x1600), глянсовий / Intel Core i5-8257U (1.4 — 3.9 ГГц) / RAM 8 ГБ / SSD 128 ГБ / Intel Iris Plus Graphics 645 / Wi-Fi / Bluetooth / macOS Mojave / 1.37 кг / сірий",
                            longDescr = "MacBook Pro задає абсолютно нові стандарти потужності й портативності ноутбуків. Процесор високої продуктивності, пам'ять більшого обсягу, передова графіка, надшвидкі накопичувачі й інші разючі здібності MacBook Pro допоможуть вам втілювати в життя будь-які творчі проєкти — ще швидше, ніж раніше.",
                            img = "/img/laptops/apple2.jpg",
                            price = 37999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Ноутбуки"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "P Smart Z Green",
                            shortDescr = "Екран (6.59\", LTPS, 2340x1080) / HiSilicon Kirin 710F(4x2.2 ГГц + 4x1.7 ГГц) / дві основні камери: 16 Мп + 2 Мп, фронтальна камера: 16 Мп / RAM 4 ГБ / 64 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / GLONASS / підтримка 2 SIM-карток (Nano-SIM) / Android 9.0 (Pie) / 4000 мА·год",
                            longDescr = "Головна відмітна риса смартфона Huawei P Smart Z — це унікальний дизайн задньої панелі. Її мерехтлива поверхня приємна на дотик і гладка як шовк. Безрамковий екран Huawei Ultra FullView 6,59 дюйма без темної зони вгорі забезпечує максимально широкий огляд. Завдяки майже повному бракуванню рамок ви відчуєте ще більше задоволення від перегляду відео, мобільних ігор або читання електронних книг.",
                            img = "/img/phones/huawei1.jpg",
                            price = 5499,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Huawei"]
                        },
                        new Product {
                            name = "ZenFone 3 ZE520KL 3/32GB (ZE520KL-1B005WW) White",
                            shortDescr = "Екран 5.2\" 1920x1080 / Cortex-A53 (64bit) 2.0 ГГц / RAM 3 GB / 32 гб вбудованої пам'яті / Android / 2600 мА·год",
                            longDescr = "ZenFone 3 – це сучасний смартфон з оригінальним дизайном і високоякісною камерою, який зробить ваше життя трохи більш незвичайним.",
                            img = "/img/phones/asus1.jpg",
                            price = 3995,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Asus"]
                        },
                        new Product {
                            name = "Xperia 10 Plus Dual Black",
                            shortDescr = "Екран (6.5\", IPS, 2520x1080) / Qualcomm Snapdragon 636 (1.8 ГГц + 1.6 ГГц) / основна подвійна камера: 12 Мп + 8 Мп, фронтальна камера: 8 Мп / RAM 4 ГБ / 64 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 9.0 (Pie) / 3000 мА·год",
                            longDescr = "Xperia 10 Plus — смартфон із широкоформатним 6.5\" дисплеєм 21:9.Працюйте одночасно у двох застосунках, дивіться фільми без чорних смуг і записуйте власні відео зі співвідношенням сторін 21:9.Усе це — у тонкому смартфоні, який зручно лежить у руці.",
                            img = "/img/phones/sony1.jpg",
                            price = 5499,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "Galaxy M21 4/64GB Green (SM-M215FZGUSEK)",
                            shortDescr = "Екран (6.4\", Super AMOLED, 2340х1080) / Samsung Exynos 9611(4 x 2.3 ГГц + 4 x 1.7 ГГц) / потрійна основна камера: 48 Мп + 8 Мп + 5 Мп, фронтальна 20 Мп / RAM 4 ГБ / 64 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 10 (Q) / 6000 мА·год",
                            longDescr = "Широкий 6.4-дюймовий безмежний U-дисплей, яким обладнаний Galaxy M21, відтворює для вас ще більше улюбленого контенту. Технологія Super AMOLED FHD+ гарантує зображення найдрібніших деталей: ви занурюєтеся до світу фільмів або ігор.Крім того, ви можете виконувати декілька завдань одночасно.",
                            img = "/img/phones/samsung1.jpg",
                            price = 5555,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Samsung"]
                        },
                        new Product {
                            name = "iPhone SE 64GB (2020) Black",
                            shortDescr = "Екран (4.7\", IPS, 1334x750) / Apple A13 Bionic / основна камера: 12 Мп, фронтальна камера: 7 Мп / 64 ГБ вбудованої пам'яті / 3G / LTE / GPS / Nano-SIM / iOS 13",
                            longDescr = "Класичний компактний дизайн, найпотужніший процесор iPhone і безліч інших переваг. iPhone SE створений, щоб стати вашим ідеальним смартфоном.",
                            img = "/img/phones/apple1.png",
                            price = 14999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "Galaxy S10 8/128 GB Black (SM-G973FZKDSEK)",
                            shortDescr = "Екран (6.1\", Dynamic AMOLED, 3040x1440) / Samsung Exynos 9820(2 x 2.7 ГГц + 2 x 2.3 ГГц + 4 x 1.9 ГГц) / потрійна основна камера: 12 Мп + 12 Мп + 16 Мп / фронтальна 10 Мп / RAM 8 ГБ / 128 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / A-GPS / ГЛОНАСС / BDS / підтримка 2 SIM-карток (Nano-SIM) / Android 9.0 (Pie) / 3400 мА·год",
                            longDescr = "Samsung створили дизайн заново, щоб ви відчули неймовірний досвід занурення в події на екрані вашого смартфона. Вся увага на екран. Високоточна лазерна обробка, вбудований ультразвуковий сканер відбитка пальця й нова технологія Dynamic AMOLED, що забезпечує комфортний перегляд, — все це імерсивний екран, найбільш інноваційний в історії Galaxy.",
                            img = "/img/phones/samsung2.jpg",
                            price = 17999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Samsung"]
                        },
                        new Product {
                            name = "P30 Lite 4/128GB Black",
                            shortDescr = "Екран (6.15\", LTPS, 2312x1080) / HiSilicon Kirin 710(4 x 2.2 ГГц + 4 x 1.7 ГГц) / потрійна основна камера: 48 Мп + 8 Мп + 2 Мп, фронтальна камера: 24 Мп / RAM 4 ГБ / 128 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / GLONASS / BDS / підтримка 2 SIM-карток (Nano-SIM) / Android 9.0 (EMUI 9.0.1) / 3340 мА·год",
                            longDescr = "Кожне обличчя унікальне. Фронтальна камера смартфона HUAWEI P30 lite зі штучним інтелектом автоматично фіксує контури обличчя та редагує селфі залежно від особливостей зовнішності, щоб ви завжди були на висоті.",
                            img = "/img/phones/huawei2.jpg",
                            price = 5499,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Huawei"]
                        },
                        new Product {
                            name = "iPhone 11 Pro 64GB Space Gray",
                            shortDescr = "Екран (5.8\", OLED (Super Retina XDR), 2436x1125) / Apple A13 Bionic / основна потрійна камера: 12 Мп + 12 Мп + 12 Мп, фронтальна камера: 12 Мп / RAM 4 ГБ / 64 ГБ вбудованої пам'яті / 3G / LTE / GPS / ГЛОНАСС / Nano-SIM / iOS 13",
                            longDescr = "Революційна система трьох камер — набагато більше можливостей і незмінна простота у використанні. Безпрецедентне збільшення ресурсу акумулятора. І надзвичайний процесор із розширеною підтримкою технологій машинного навчання, який відкриває для iPhone великі, нові перспективи. Apple представляє iPhone 11 Pro. Він гідний свого імені.",
                            img = "/img/phones/apple2.jpg",
                            price = 32999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "Redmi 8 3/32 Blue (Global ROM + OTA)",
                            shortDescr = "Экран (6.22'', IPS, 1520x720)/ Qualcomm Snapdragon 439 (4 x 1.95 ГГц + 4 х 1.45 ГГц)/ основная двойная камера: 12 Мп + 2 Мп, фронтальная камера: 8 Мп/ RAM 3 ГБ/ 32 ГБ встроенной памяти + microSD (до 512 ГБ)/ 3G/ LTE/ GPS/ ГЛОНАСС/ поддержка 2х SIM-карт (Nano-SIM)/ Android 9.0 (Pie)/ 5000 мА*ч",
                            longDescr = "Класичний компактний дизайн, потужний процесор і безліч інших переваг. Xiaomi Redmu 8 створений, щоб стати вашим ідеальним смартфоном.",
                            img = "/img/phones/xiaomi1.jpg",
                            price = 3099,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Xiaomi"]
                        },
                        new Product {
                            name = "Redmi Note 9S 4/64GB Interstellar Grey",
                            shortDescr = "Екран (6.67\", IPS, 2400x1080) / Qualcomm Snapdragon 720G(2x2.3 ГГц + 6x1.8 ГГц) / основна квадрокамера: 48 Мп + 8 Мп + 5 Мп + 2 Мп, фронтальна 16 Мп / RAM 4 ГБ / 64 ГБ вбудованої пам'яті + microSD (до 512 ГБ) / 3G / LTE / GPS / підтримка 2 SIM-карток (Nano-SIM) / Android 10.0 (Q) / 5020 мА·год",
                            longDescr = "Основна камера Redmi Note 9S складається з чотирьох датчиків, включно з головним модулем із роздільною здатністю 48 Мп. Відчуйте на власному досвіді, що означає новий рівень мобільної фотографії, і робіть професійні знімки одним натисненням.",
                            img = "/img/phones/xiaomi2.jpg",
                            price = 5999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Смартфони"],
                            Manufacturer = Manufacturers["Xiaomi"]
                        },
                        new Product {
                            name = "Transformer Mini T102HA 4Гб Ram",
                            shortDescr = "Екран 10.1\" IPS (2160x1620) ємнісний Multi-Touch / RAM 4 ГБ / 32 ГБ вбудованої пам'яті / Wi-Fi / Bluetooth 4.2 / основна камера 8 Мп, фронтальна — 1.2 Мп / 800 г",
                            longDescr = "Надзвичайно тонкий та надлегкий 10,1-дюймовий ASUS Transformer Mini — це одразу два пристрої в одному! Створений у корпусі з алюмінієво-магнієвого сплаву, цей ультрапортативний пристрій '2-в-1' важить менше 800 грамів, працює до 11 годин на одному заряді батареї й підтримує всі інноваційні функції Windows 10.",
                            img = "/img/tablets/asus.jpg",
                            price = 5999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Планшети"],
                            Manufacturer = Manufacturers["Asus"]
                        },
                        new Product {
                            name = "One 10 S1003P-1339 10.1",
                            shortDescr = "Екран 10.1\" IPS (2160x1620) ємнісний Multi-Touch / RAM 4 ГБ / 32 ГБ вбудованої пам'яті / Wi-Fi / Bluetooth 4.2 / основна камера 8 Мп, фронтальна — 1.2 Мп / 800 г",
                            longDescr = "Іноді вам потрібен планшет, а іноді - ноутбук. C Acer One 10 вам не доведеться вибирати. Працюйте, грайте, обмінюйтеся файлами - що завгодно на цьому пристрої.",
                            img = "/img/tablets/acer.jpg",
                            price = 11999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Планшети"],
                            Manufacturer = Manufacturers["Acer"]
                        },
                        new Product {
                            name = "iPad 10.2\" Wi-Fi 32GB Space Gray (MW742)",
                            shortDescr = "Екран 10.2\" IPS (2160x1620) ємнісний Multi-Touch / Apple A10 Fusion / RAM 3 ГБ / 32 ГБ вбудованої пам'яті / Wi-Fi / Bluetooth 4.2 / основна камера 8 Мп, фронтальна — 1.2 Мп / iPadOS / 483 г / сірий космос",
                            longDescr = "Новий iPad — це можливості потужного комп'ютера в поєднанні з простотою й універсальністю портативного пристрою. Тепер його обладнано збільшеним дисплеєм Retina 10,2 дюйма, підтримує повнорозмірну клавіатуру Smart Keyboard і приголомшливі нові функції iPadOS. Стільки задоволення — тільки з iPad.",
                            img = "/img/tablets/apple.jpg",
                            price = 10999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Планшети"],
                            Manufacturer = Manufacturers["Apple"]
                        },
                        new Product {
                            name = "Galaxy Tab A 10.1 32GB LTE Black (SM-T515NZKDSEK)",
                            shortDescr = "Екран 10.1\" (1920x1080) ємнісний MultiTouch / Samsung Exynos 7904 (2x1.8 ГГц + 6x1.6 ГГц) / RAM 2 ГБ / 32 ГБ вбудованої пам'яті + microSD / 3G / LTE / Wi-Fi / Bluetooth 5.0 / основна камера 8 Мп, фронтальна — 5 Мп / GPS / ГЛОНАСС / Android 9.0 (Pie) / 470 г / чорний",
                            longDescr = "Виробники створили універсальний і функціональний планшет, доступний для кожного. З Galaxy Tab A10.1 (2019) ви матимете досвід використання пристрою преміального рівня за демократичною ціною.",
                            img = "/img/tablets/samsung.jpg",
                            price = 7499,
                            isFavourite =true ,
                            available = true,
                            Category = Categories["Планшети"],
                            Manufacturer = Manufacturers["Samsung"]
                        },
                        new Product {
                            name = "MediaPad M5 Lite 10\" 4/64GB Wi-Fi Grey (BAH2-W19)",
                            shortDescr = "Екран 10.1\" IPS (1920x1200) MultiTouch / HiSilicon Kirin 659 (2.36 ГГц + 1.7 ГГц) / RAM 4 ГБ / 64 ГБ вбудованої пам'яті + microSD / Wi-Fi / Bluetooth 4.2 / основна камера 8 Мп, фронтальна 8 Мп / GPS / ГЛОНАСС / Android 8.0 (EMUI) / 475 г / сірий",
                            longDescr = "Відкрийте світ краси та досконалості з Huawei MediaPad M5 10\"! Оцініть багатство кольорової палітри та чудову якість стильного планшета з корпусом з анодованого алюмінію й екраном 10,1 дюйма.",
                            img = "/img/tablets/huawei.jpg",
                            price = 8999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Планшети"],
                            Manufacturer = Manufacturers["Huawei"]
                        },
                        new Product {
                            name = "UE55TU7100UXUA",
                            shortDescr = "55\" / 3840x2160 / DVB - T, DVB - C, DVB - S, DVB - S2, DVB - T2 / Tizen / 2000 Гц(PQI)",
                            longDescr = "Пориньте в зображення з ширшою кольоровою гамою. Технологія Crystal Display забезпечує оптимізовану виразність кольорів, щоб ви могли побачити кожну деталь.",
                            img = "/img/tvs/samsung1.jpg",
                            price = 15499,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Телевізори"],
                            Manufacturer = Manufacturers["Samsung"]
                        },
                        new Product {
                            name = "KDL-32RE303 Black",
                            shortDescr = "32\" / 1366x768 / DVB - T, DVB - C, DVB - T2 / 100 Гц(MotionFlow)",
                            longDescr = "Відчуйте неймовірну деталізацію, контрастність і текстуру. Усе, що ви переглядаєте, очищається і вдосконалюється, щоб забезпечити мінімальний шум і максимальну якість.",
                            img = "/img/tvs/sony1.jpg",
                            price = 6999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Телевізори"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "KDL43WF805BR Black",
                            shortDescr = " 43\" / 1920x1080 / DVB - T, DVB - C, DVB - S, DVB - S2, DVB - T2 / Android TV / 400 Гц(MotionFlow)",
                            longDescr = "Дізнайтеся про HDR і технології підвищення розділення в наших телевізорах з Android TV, а також простий та швидкий пошук контенту за допомогою голосових команд.",
                            img = "/img/tvs/sony2.jpg",
                            price = 11499,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Телевізори"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "Mi LED TV 4S 43\" UHD 4K (L43M5-5ARU)",
                            shortDescr = "43\" / 3840x2160 / DVB - C, DVB - T2 / Android",
                            longDescr = "64-розрядний чотириядерний процесор для швидкої обробки даних і великий обсяг вбудованої пам'яті дає змогу встановлювати додаткові програми.",
                            img = "/img/tvs/xiaomi1.jpg",
                            price = 8499,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Телевізори"],
                            Manufacturer = Manufacturers["Xiaomi"]
                        },
                        new Product {
                            name = "QE65Q60TAUXUA",
                            shortDescr = "65\" / 3840x2160 / DVB - T, DVB - C, DVB - S, DVB - S2, DVB - T2 / Tizen / 3100 Гц(PQI)",
                            longDescr = "Технологія квантових точок нового телевізора QLED Samsung забезпечує найкращу якість зображення. За рахунок 100% кольорового охоплення, квантові точки перетворюють світло в захоплюючий колір, що залишається справжнім за будь якого рівня яскравості.",
                            img = "/img/tvs/samsung2.jpg",
                            price = 43999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Телевізори"],
                            Manufacturer = Manufacturers["Samsung"]
                        },
                        new Product {
                            name = "EOS 4000D BK 18-55 (3011C004AA)",
                            shortDescr = "Матриця 22.3 x 14.9 мм, 18 Мп / об'єктив 18-55 мм III / Зум: 3х (оптичний)/підтримка карток пам'яті SD / SDHC / SDXC / 2.7\" РК-екран / Full HD-відео / Wi-Fi / живлення від літій-іонного акумулятора / 129 x 101.6 x 77.1 мм, 436 г (тільки корпус)/чорний",
                            longDescr = "Знімайте та діліться без зайвих зусиль: створюйте унікальні історії з високим рівнем передавання кольору та деталізації, а також із красивим розмиванням заднього плану, яке дасть змогу вам виділитися серед інших.",
                            img = "/img/cameras/canon1.jpg",
                            price = 9299,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                        new Product {
                            name = "EOS 77D EF-S 18-135mm IS USM Kit Black (1892C024)",
                            shortDescr = "Матриця CMOS 22.3 x 14.9 мм, 24.2 Мп / Об'єктив EF-S 18-135mm IS USM / підтримка карток пам'яті SD/SDHC/SDXC / LCD-дисплей 3\" / Full HD-відео / Wi-Fi / живлення від літій-іонного акумулятора / 131 x 172.2 x 99.9 мм, 1055 г (з об'єктивом)",
                            longDescr = "Ультратонка камера з можливістю під'єднання до смартфона надає простір для творчості, забезпечує чудові результати та дає змогу самостійно обирати рівень контролю над параметрами знімання",
                            img = "/img/cameras/canon2.jpg",
                            price = 21999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                        new Product {
                            name = "Alpha А7 III Body Black (ILCE7M3B.CEC)",
                            shortDescr = "Матриця 35.6 x 23.8 мм, 24.2 Мп / підтримка карт пам'яті MS PRO Duo / MS PRO-HG Duo / Stick Micro (M2) / SD / SDHC / SDXC / РК-дисплей 3\" / UHD 4K-відео / Wi-Fi / NFC / Bluetooth / живлення від літій-іонного акумулятора / 126.9 х 95.6 х 73.7 мм / 650 г / чорний",
                            longDescr = "Камера α7 III від Sony поєднує нову повнокадрову CMOS-матрицю з тиловою підсвіткою і інші інноваційні технології формування зображення. А висока швидкість відгуку, простота використання і зносостійкість камери дасть змогу реалізувати будь-які творчі задуми.",
                            img = "/img/cameras/sony1.jpg",
                            price = 49999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "Alpha a6500 Body Black (ILCE6500B.CEC)",
                            shortDescr = "Матриця 23.5 x 15.6 мм, 24.2 Мп / Зум: 8х (цифровий) / підтримка карт пам'яті PRO Duo / PRO-HG Duo / Micro (M2) / SD / SDHC / SDXC / microSD / microSDHC / microSDXC / похилий LCD-дисплей 3\" / Wi-Fi / NFC / живлення від літій-іонного акумулятора / 120 x 66.9 x 53.3 мм, 453 г / чорний",
                            longDescr = "Камера α6500 має точне автофокусування, бездоганну стабільність знімання, інтуїтивний сенсорний екран — і водночас поміщається в долоні. Вона створена, щоб ви не проґавили жодного вдалого кадру.",
                            img = "/img/cameras/sony2.jpg",
                            price = 29999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "D5600 AF-P 18-55mm f/3.5-5.6G VR Black (VBA500K001)",
                            shortDescr = "Матриця 23.5 x 15.6 мм, 24.2 Мп / об'єктив 18-55mm f/3.5-5.6G VR / Зум: 0.82х / підтримка карток пам'яті SD/SDHC/SDXC / РК-дисплей 3.2\" / Full HD-відео / живлення від літій-іонного акумулятора / 124 x 97 x 133 мм, 660 г / чорний",
                            longDescr = "Завдяки передовим технологіям оброблення зображень від компанії Nikon фотокамера D5600 здатна творити справжні чудеса. Вона допоможе вам реалізувати найсміливіші ідеї. Широкий вибір легендарних об'єктивів NIKKOR означає, що у вас завжди знайдуться кошти для втілення будь-яких творчих задумів. А застосунок Nikon SnapBridge дає змогу синхронізувати зображення з інтелектуальним пристроєм під час знімання або за бажання легко передавати відеоролики.",
                            img = "/img/cameras/nikon1.jpg",
                            price = 18999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Nikon"]
                        },
                        new Product {
                            name = "D780 Body Black (VBA560AE)",
                            shortDescr = "Матриця 35.9 x 23.9 мм, 24.5 Мп / підтримка карток пам'яті SD/SDHC/SDXC / РК-дисплей 3.2\" / UltraHD-відео / Wi-Fi / Bluetooth / живлення від літій-іонного акумулятора / 143.5 x 115.5 x 76 мм, 840 г з батареєю і карткою пам'яті / чорний",
                            longDescr = "Нехай ніщо не встане між вами та вашим баченням світу. Фотокамера D780 дає вам усе, чого ви очікуєте від професійної цифрової дзеркальної фотокамери й багато іншого. Чітке зображення. Великий ресурс роботи батареї. Міцна конструкція. Плюс дві швидкі та надійні системи АФ, феноменальні можливості стеження, широкий діапазон чутливості ISO і багато іншого. Постановні кадри або фотографування в природних умовах. Світлини або відеоролики. Ця повнокадрова цифрова дзеркальна фотокамера не відає страху.",
                            img = "/img/cameras/nikon2.jpg",
                            price = 64999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Nikon"]
                        },
                        new Product {
                            name = "EOS 250D BK 18-55 IS (3454C007AA)",
                            shortDescr = "Матриця 22.3 x 14.9 мм, 24.1 Мп / об'єктив EF-S 18-55 mm f/3.5-5.6 IS STM / підтримка карток пам'яті SD/SDHC/SDXC / Сенсорний РК-дисплей Clear View II TFT 3\" / 4K-відео / живлення від літій-іонного акумулятора / 122.4 x 145 x 92.6 мм, 654 г (включно з об'єктивом, акумулятором і карткою пам'яті)",
                            longDescr = "Canon EOS 250D — найлегша у світі цифрова дзеркальна камера з поворотним екраном поєднує в собі знімання в традиційному положенні та передові технології. Камера дає змогу з легкістю створювати прекрасні фотографії та відео у форматі 4K і забезпечує інтуїтивну взаємодію з мобільними пристроями.",
                            img = "/img/cameras/canon3.jpg",
                            price = 16299,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                        new Product {
                            name = "D750 Body",
                            shortDescr = "Матриця КМОП, 35.9 x 24.0 мм, 24.3 Мп / підтримка карток пам'яті SD/SDHC/SDXC / поворотний LCD-дисплей 3.2\" / живлення від літій-іонного акумулятора / 140.5 x 113 x 78 мм, 840 г",
                            longDescr = "Розкрийте своє бачення світу завдяки універсальній моделі D750 з гнучкими настройками та високою швидкістю знімання. Відкрийте для себе світ необмежених можливостей: дерзайте та перемагайте за допомогою повнокадрової 24.3-мегапіксельної фотокамери. Ця фотокамера, яка поєднує технології професійного рівня й ергономічну компактну конструкцію, не знає перешкод для знімання.",
                            img = "/img/cameras/nikon3.jpg",
                            price = 37999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Фотоапарати"],
                            Manufacturer = Manufacturers["Nikon"]
                        },
                        new Product {
                            name = "Legria HF R806 Black (1960C008)",
                            shortDescr = "Flash пам'ять / 3.28 мегапікселя / 2.07 мегапікселя / Фільтр Баєра / Удосконалене збільшення 57x / Оптичне збільшення 32x / Цифрове збільшення 1040x",
                            longDescr = "Canon Legria HF R806 — доступна та зручна відеокамера з великим зумом забезпечує чудову якість зображення і звуку під час знімання пам'ятних подій.",
                            img = "/img/videocameras/canon1.jpg",
                            price = 6699,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Відеокамери"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                        new Product {
                            name = "HDR-CX625 Black (HDRCX625B.CEL)",
                            shortDescr = "Flash пам'ять / Exmor R CMOS з тиловою підсвіткою / Оптичний - 30x / Цифровий - 350x",
                            longDescr = "Відеокамера HD Handycam вирізняється стійкістю знімання, плавним автофокусуванням (АФ) і стабілізацією зображення для створення чудових відео.",
                            img = "/img/videocameras/sony1.jpg",
                            price = 12999,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Відеокамери"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "LEGRIA HF G26 (F00165933)",
                            shortDescr = "1 / 2.84-дюймовий покращений датчик HD CMOS PRO / 3.09 Мп(2208x1398) / 2.91 Мп(2136x1362) / 2.07 Мп(в режимі 16: 9) / Фільтр основних кольорів RGB",
                            longDescr = "Canon Legria HF G26 — доступна та зручна відеокамера з великим зумом забезпечує чудову якість зображення і звуку під час знімання пам'ятних подій.",
                            img = "/img/videocameras/canon2.jpg",
                            price = 31299,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Відеокамери"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                        new Product {
                            name = "RX0 II + VCT-SGR1 (DSCRX0M2G.CEE)",
                            shortDescr = "Flash пам'ять / CMOS Exmor RS типу 1.0(13.2 мм x 8.8 мм), співвідношення сторін 3:2 / Цифровий:-Фото: 15 Мп, прибл. 4x / 7.7 Мп, прибл. 5.6x / 3.8 Мп, прибл. 8x / VGA, прибл. 13x  Відео: приблизно 4x",
                            longDescr = "Камера RX0 II ідеально підходить для повсякденного знімання. Завдяки потужній однодюймовій матриці й об'єктиву ZEISS Tessar T з низьким рівнем спотворення ви отримаєте чудові зображення навіть у разі тьмяного світла та зможете легко поділитися ними за допомогою смартфона. Серед інших переваг цієї камери — запис 4K-відео у внутрішню пам'ять, неймовірна стабілізація зображення, мінімальна фокусна відстань 20 см і РК-екран із кутом нахилу 180°.",
                            img = "/img/videocameras/sony2.jpg",
                            price = 23999,
                            isFavourite = false,
                            available = true,
                            Category = Categories["Відеокамери"],
                            Manufacturer = Manufacturers["Sony"]
                        },
                        new Product {
                            name = "Legria HF R88 Black (1959C007)",
                            shortDescr = "1/4.85\" CMOS / Зум: 1140 x",
                            longDescr = "З легкістю знімайте і діліться записами важливих подій в форматі HD за допомогою цієї потужної відеокамери з ширококутним об'єктивом, можливостями підключення і вдосконаленим 57-кратним зумом. Знімайте важливі сімейні події у відмінній якості без зайвих зусиль.",
                            img = "/img/videocameras/canon3.jpg",
                            price = 10699,
                            isFavourite = true,
                            available = true,
                            Category = Categories["Відеокамери"],
                            Manufacturer = Manufacturers["Canon"]
                        },
                    };

                    product = new Dictionary<string, Product>();
                    foreach (Product el in list)
                    {
                        product.Add(el.name, el);
                    }
                }

                return product;
            }
        }
    }
}
