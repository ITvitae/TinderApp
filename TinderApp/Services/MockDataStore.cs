using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinderApp.Models;

namespace TinderApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
			items = new List<Item>()
			{
				new Item { Id="1", FullName="Merissa Bellsham", Gender=(GenderEnum) 2, Age="23", City="Hòa Bình", Country="Vietnam", Description = DescriptionClass.Line1},
				new Item { Id="1", FullName="Merissa Bellsham", Gender=(GenderEnum) 2, Age="23", City="Hòa Bình", Country="Vietnam", Description = DescriptionClass.Line1},
				new Item { Id="2", FullName="Reamonn Kellaway", Gender=(GenderEnum) 2, Age="18", City="Stará Huť", Country="Czech Republic", Description = DescriptionClass.Line9},
				new Item { Id="3", FullName="Prentice Fattorini", Gender=(GenderEnum) 2, Age="25", City="Peicheng", Country="China", Description = DescriptionClass.Line4},
				new Item { Id="4", FullName="Rutter Search", Gender=(GenderEnum) 2, Age="23", City="Xinzhou", Country="China", Description = DescriptionClass.Line4},
				new Item { Id="5", FullName="Marget Curteis", Gender=(GenderEnum) 1, Age="19", City="Mīrābād", Country="Afghanistan", Description = DescriptionClass.Line9},
				new Item { Id="6", FullName="Arlee Corps", Gender=(GenderEnum) 1, Age="21", City="Ḩammām Wāşil", Country="Syria", Description = DescriptionClass.Line4},
				new Item { Id="7", FullName="Dre Mullane", Gender=(GenderEnum) 0, Age="18", City="Golcowa", Country="Poland", Description = DescriptionClass.Line7},
				new Item { Id="8", FullName="Daisey Holdforth", Gender=(GenderEnum) 2, Age="22", City="Flying Fish Cove", Country="Christmas Island", Description = DescriptionClass.Line9},
				new Item { Id="9", FullName="Gerhardine Danby", Gender=(GenderEnum) 2, Age="23", City="Patrol", Country="Indonesia", Description = DescriptionClass.Line7},
				new Item { Id="10", FullName="Morissa Aulton", Gender=(GenderEnum) 2, Age="24", City="Chernigovka", Country="Russia", Description = DescriptionClass.Line0},
				new Item { Id="11", FullName="Valeria Heathorn", Gender=(GenderEnum) 0, Age="24", City="Pustá Polom", Country="Czech Republic", Description = DescriptionClass.Line0},
				new Item { Id="12", FullName="Frans Woodyeare", Gender=(GenderEnum) 2, Age="20", City="Guluoshan", Country="China", Description = DescriptionClass.Line9},
				new Item { Id="13", FullName="Noach Krzyzowski", Gender=(GenderEnum) 2, Age="22", City="Oslo", Country="Norway", Description = DescriptionClass.Line6},
				new Item { Id="14", FullName="Elmo Apark", Gender=(GenderEnum) 1, Age="19", City="Adassil", Country="Morocco", Description = DescriptionClass.Line3},
				new Item { Id="15", FullName="Ernestus Van T'Hoog", Gender=(GenderEnum) 2, Age="18", City="Labuhanlalar", Country="Indonesia", Description = DescriptionClass.Line9},
				new Item { Id="16", FullName="Lebbie Colhoun", Gender=(GenderEnum) 2, Age="20", City="Tanjay", Country="Philippines", Description = DescriptionClass.Line4},
				new Item { Id="17", FullName="Moyra Sirey", Gender=(GenderEnum) 1, Age="23", City="Gelatik", Country="Indonesia", Description = DescriptionClass.Line7},
				new Item { Id="18", FullName="Dennis Bruckmann", Gender=(GenderEnum) 0, Age="18", City="Divo", Country="Ivory Coast", Description = DescriptionClass.Line7},
				new Item { Id="19", FullName="Bryana Sargeant", Gender=(GenderEnum) 2, Age="21", City="Xilian", Country="China", Description = DescriptionClass.Line6},
				new Item { Id="20", FullName="Carmella Cromleholme", Gender=(GenderEnum) 2, Age="23", City="Hexi", Country="China", Description = DescriptionClass.Line1},
				new Item { Id="21", FullName="Torey Silverman", Gender=(GenderEnum) 1, Age="20", City="Uglegorsk", Country="Russia", Description = DescriptionClass.Line10},
				new Item { Id="22", FullName="Tabby Matthew", Gender=(GenderEnum) 1, Age="24", City="Nynäshamn", Country="Sweden", Description = DescriptionClass.Line4},
				new Item { Id="23", FullName="Ulberto Peach", Gender=(GenderEnum) 0, Age="20", City="Mūsa Khel Bāzār", Country="Pakistan", Description = DescriptionClass.Line10},
				new Item { Id="24", FullName="Eda Balmann", Gender=(GenderEnum) 2, Age="21", City="Arzakan", Country="Armenia", Description = DescriptionClass.Line8},
				new Item { Id="25", FullName="Lynn Fisby", Gender=(GenderEnum) 2, Age="24", City="Loei", Country="Thailand", Description = DescriptionClass.Line2},
				new Item { Id="26", FullName="Dyna Haslam", Gender=(GenderEnum) 2, Age="19", City="Yurla", Country="Russia", Description = DescriptionClass.Line3},
				new Item { Id="27", FullName="Sibbie Peace", Gender=(GenderEnum) 2, Age="18", City="Krajan Gading", Country="Indonesia", Description = DescriptionClass.Line1},
				new Item { Id="28", FullName="Farley Sedgeman", Gender=(GenderEnum) 2, Age="25", City="Vysotsk", Country="Russia", Description = DescriptionClass.Line2},
				new Item { Id="29", FullName="Nissy Pearn", Gender=(GenderEnum) 0, Age="18", City="Smiths Falls", Country="Canada", Description = DescriptionClass.Line5},
				new Item { Id="30", FullName="Ramona Esilmon", Gender=(GenderEnum) 2, Age="21", City="Siuna", Country="Nicaragua", Description = DescriptionClass.Line7},
				new Item { Id="31", FullName="Eydie Jann", Gender=(GenderEnum) 0, Age="20", City="Reshetnikovo", Country="Russia", Description = DescriptionClass.Line9},
				new Item { Id="32", FullName="Thorin Gurge", Gender=(GenderEnum) 2, Age="23", City="Mauponggo", Country="Indonesia", Description = DescriptionClass.Line4},
				new Item { Id="33", FullName="Judye Bakeup", Gender=(GenderEnum) 1, Age="18", City="Inawashiro", Country="Japan", Description = DescriptionClass.Line2},
				new Item { Id="34", FullName="Yorgos Sidgwick", Gender=(GenderEnum) 0, Age="20", City="Pamedilan", Country="Indonesia", Description = DescriptionClass.Line2},
				new Item { Id="35", FullName="Steven Golland", Gender=(GenderEnum) 1, Age="20", City="Oslo", Country="Norway", Description = DescriptionClass.Line7},
				new Item { Id="36", FullName="Bradney Scandwright", Gender=(GenderEnum) 2, Age="19", City="Žďár nad Sázavou", Country="Czech Republic", Description = DescriptionClass.Line4},
				new Item { Id="37", FullName="Aleksandr Kirsche", Gender=(GenderEnum) 0, Age="18", City="Seredka", Country="Russia", Description = DescriptionClass.Line7},
				new Item { Id="38", FullName="Hewett Freestone", Gender=(GenderEnum) 0, Age="21", City="Donostia-San Sebastian", Country="Spain", Description = DescriptionClass.Line4},
				new Item { Id="39", FullName="Cammy Stanyard", Gender=(GenderEnum) 2, Age="24", City="Vũng Tàu", Country="Vietnam", Description = DescriptionClass.Line9},
				new Item { Id="40", FullName="Joyce Semarke", Gender=(GenderEnum) 1, Age="25", City="Toshkivka", Country="Ukraine", Description = DescriptionClass.Line9},
				new Item { Id="41", FullName="Allen Boydon", Gender=(GenderEnum) 2, Age="21", City="Farranacoush", Country="Ireland", Description = DescriptionClass.Line6},
				new Item { Id="42", FullName="Rollins Coraini", Gender=(GenderEnum) 1, Age="24", City="Ubonratana", Country="Thailand", Description = DescriptionClass.Line2},
				new Item { Id="43", FullName="Romain Berrington", Gender=(GenderEnum) 2, Age="18", City="Ogawa", Country="Japan", Description = DescriptionClass.Line10},
				new Item { Id="44", FullName="Tamqrah Freiberg", Gender=(GenderEnum) 1, Age="21", City="Santa Bernardina", Country="Uruguay", Description = DescriptionClass.Line7},
				new Item { Id="45", FullName="Michel Kiff", Gender=(GenderEnum) 0, Age="19", City="Novoalekseyevskaya", Country="Russia", Description = DescriptionClass.Line10},
				new Item { Id="46", FullName="Hamilton Crampsey", Gender=(GenderEnum) 0, Age="21", City="Thionville", Country="France", Description = DescriptionClass.Line4},
				new Item { Id="47", FullName="Homerus Gass", Gender=(GenderEnum) 1, Age="19", City="Tashla", Country="Russia", Description = DescriptionClass.Line3},
				new Item { Id="48", FullName="Cahra Scarlon", Gender=(GenderEnum) 0, Age="23", City="Jönköping", Country="Sweden", Description = DescriptionClass.Line8},
				new Item { Id="49", FullName="Augusta Sollner", Gender=(GenderEnum) 2, Age="20", City="Gwadabawa", Country="Nigeria", Description = DescriptionClass.Line8},
				new Item { Id="50", FullName="Paige Kmietsch", Gender=(GenderEnum) 1, Age="19", City="Norzagaray", Country="Philippines", Description = DescriptionClass.Line6},
				new Item { Id="51", FullName="Leanor Quiddington", Gender=(GenderEnum) 1, Age="20", City="Skënderbegas", Country="Albania", Description = DescriptionClass.Line8},
				new Item { Id="52", FullName="Addi Fitzgerald", Gender=(GenderEnum) 1, Age="24", City="Rekovac", Country="Serbia", Description = DescriptionClass.Line4},
				new Item { Id="53", FullName="Prent Foulis", Gender=(GenderEnum) 1, Age="18", City="Vorontsovka", Country="Russia", Description = DescriptionClass.Line5},
				new Item { Id="54", FullName="Fran Bleakley", Gender=(GenderEnum) 2, Age="24", City="Hanna", Country="Canada", Description = DescriptionClass.Line0},
				new Item { Id="55", FullName="Holmes Gamil", Gender=(GenderEnum) 2, Age="18", City="Chatou", Country="China", Description = DescriptionClass.Line9},
				new Item { Id="56", FullName="Sephira Swaby", Gender=(GenderEnum) 2, Age="23", City="Karanggeneng", Country="Indonesia", Description = DescriptionClass.Line8},
				new Item { Id="57", FullName="Alida Woodrup", Gender=(GenderEnum) 2, Age="20", City="Homeyo", Country="Indonesia", Description = DescriptionClass.Line10},
				new Item { Id="58", FullName="Bertie Goodin", Gender=(GenderEnum) 1, Age="20", City="Buenavista", Country="Mexico", Description = DescriptionClass.Line6},
				new Item { Id="59", FullName="Alisander Kier", Gender=(GenderEnum) 1, Age="22", City="Komenda", Country="Slovenia", Description = DescriptionClass.Line7},
				new Item { Id="60", FullName="Manda Lampart", Gender=(GenderEnum) 2, Age="21", City="Dongbang", Country="China", Description = DescriptionClass.Line6},
				new Item { Id="61", FullName="Doll Hardwidge", Gender=(GenderEnum) 2, Age="21", City="Krasnoye", Country="Russia", Description = DescriptionClass.Line2},
				new Item { Id="62", FullName="Luca Mulqueen", Gender=(GenderEnum) 2, Age="20", City="Alvide", Country="Portugal", Description = DescriptionClass.Line6},
				new Item { Id="63", FullName="Gillie Wellbank", Gender=(GenderEnum) 2, Age="23", City="Dizangué", Country="Cameroon", Description = DescriptionClass.Line3},
				new Item { Id="64", FullName="Jesus Dalgliesh", Gender=(GenderEnum) 2, Age="22", City="Tawun", Country="Indonesia", Description = DescriptionClass.Line4},
				new Item { Id="65", FullName="Millicent Pietron", Gender=(GenderEnum) 2, Age="19", City="Tegalgede", Country="Indonesia", Description = DescriptionClass.Line0},
				new Item { Id="66", FullName="Dyan Hindrick", Gender=(GenderEnum) 2, Age="24", City="Nîmes", Country="France", Description = DescriptionClass.Line7},
				new Item { Id="67", FullName="Charlena Keetch", Gender=(GenderEnum) 0, Age="22", City="Putang", Country="China", Description = DescriptionClass.Line10},
				new Item { Id="68", FullName="Lorant Crimes", Gender=(GenderEnum) 2, Age="24", City="Quvasoy", Country="Uzbekistan", Description = DescriptionClass.Line6},
				new Item { Id="69", FullName="Emalia Cadwell", Gender=(GenderEnum) 2, Age="25", City="Shemonaīkha", Country="Kazakhstan", Description = DescriptionClass.Line6},
				new Item { Id="70", FullName="Geri Hobden", Gender=(GenderEnum) 2, Age="18", City="Itupeva", Country="Brazil", Description = DescriptionClass.Line5},
				new Item { Id="71", FullName="Chariot MacFadzan", Gender=(GenderEnum) 1, Age="21", City="Wuxi", Country="China", Description = DescriptionClass.Line9},
				new Item { Id="72", FullName="Margarethe Spelling", Gender=(GenderEnum) 1, Age="20", City="Zhonghe", Country="China", Description = DescriptionClass.Line7},
				new Item { Id="73", FullName="Maryanne Santacrole", Gender=(GenderEnum) 2, Age="18", City="Bielawy", Country="Poland", Description = DescriptionClass.Line9},
				new Item { Id="74", FullName="Dayna Douglass", Gender=(GenderEnum) 2, Age="20", City="Modot", Country="Mongolia", Description = DescriptionClass.Line4},
				new Item { Id="75", FullName="Fred Willerson", Gender=(GenderEnum) 2, Age="18", City="Falun", Country="Sweden", Description = DescriptionClass.Line3},
				new Item { Id="76", FullName="Diannne Wetherburn", Gender=(GenderEnum) 2, Age="23", City="Mississauga", Country="Canada", Description = DescriptionClass.Line8},
				new Item { Id="77", FullName="Gill Bernhardt", Gender=(GenderEnum) 2, Age="22", City="Tacoma", Country="United States", Description = DescriptionClass.Line5},
				new Item { Id="78", FullName="Philippine Mintrim", Gender=(GenderEnum) 0, Age="24", City="Kadukaung", Country="Indonesia", Description = DescriptionClass.Line8},
				new Item { Id="79", FullName="Dieter Fullager", Gender=(GenderEnum) 2, Age="21", City="Châteauroux", Country="France", Description = DescriptionClass.Line7},
				new Item { Id="80", FullName="Rolland Felix", Gender=(GenderEnum) 2, Age="22", City="Yekimovichi", Country="Russia", Description = DescriptionClass.Line0},
				new Item { Id="81", FullName="Agustin Chatin", Gender=(GenderEnum) 0, Age="22", City="Şaḩneh", Country="Iran", Description = DescriptionClass.Line0},
				new Item { Id="82", FullName="Stacee Sabbin", Gender=(GenderEnum) 2, Age="19", City="Banjar Jagasatru", Country="Indonesia", Description = DescriptionClass.Line6},
				new Item { Id="83", FullName="Oralla Newson", Gender=(GenderEnum) 2, Age="20", City="Fushë-Muhurr", Country="Albania", Description = DescriptionClass.Line8},
				new Item { Id="84", FullName="Morgana Brimmell", Gender=(GenderEnum) 1, Age="25", City="Qarāwul", Country="Afghanistan", Description = DescriptionClass.Line5},
				new Item { Id="85", FullName="Sherilyn Caswell", Gender=(GenderEnum) 2, Age="23", City="Makariv", Country="Ukraine", Description = DescriptionClass.Line2},
				new Item { Id="86", FullName="Halsey Yaakov", Gender=(GenderEnum) 0, Age="18", City="Turkestan", Country="Kazakhstan", Description = DescriptionClass.Line7},
				new Item { Id="87", FullName="Idalina Baleine", Gender=(GenderEnum) 0, Age="19", City="Kushiro", Country="Japan", Description = DescriptionClass.Line10},
				new Item { Id="88", FullName="Ardyce Humes", Gender=(GenderEnum) 0, Age="23", City="Karlstad", Country="Sweden", Description = DescriptionClass.Line2},
				new Item { Id="89", FullName="Joby Zmitruk", Gender=(GenderEnum) 1, Age="24", City="Quinta da Torre", Country="Portugal", Description = DescriptionClass.Line9},
				new Item { Id="90", FullName="Jilli Dieton", Gender=(GenderEnum) 2, Age="24", City="Caieiras", Country="Brazil", Description = DescriptionClass.Line9},
				new Item { Id="91", FullName="Darbie Balnave", Gender=(GenderEnum) 2, Age="21", City="Kertayuga", Country="Indonesia", Description = DescriptionClass.Line10},
				new Item { Id="92", FullName="Robbyn Tayt", Gender=(GenderEnum) 0, Age="20", City="Tamahú", Country="Guatemala", Description = DescriptionClass.Line8},
				new Item { Id="93", FullName="Ardath Fayers", Gender=(GenderEnum) 2, Age="18", City="Zhaocun", Country="China", Description = DescriptionClass.Line3},
				new Item { Id="94", FullName="Lazarus Dulany", Gender=(GenderEnum) 0, Age="22", City="Brangsi", Country="Indonesia", Description = DescriptionClass.Line6},
				new Item { Id="95", FullName="Lindsy Delgardo", Gender=(GenderEnum) 1, Age="24", City="Booterstown", Country="Ireland", Description = DescriptionClass.Line7},
				new Item { Id="96", FullName="Laurens Hun", Gender=(GenderEnum) 2, Age="21", City="Opatowiec", Country="Poland", Description = DescriptionClass.Line7},
				new Item { Id="97", FullName="Ruthanne Loeber", Gender=(GenderEnum) 1, Age="20", City="Puyan", Country="China", Description = DescriptionClass.Line1},
				new Item { Id="98", FullName="Joe Dotterill", Gender=(GenderEnum) 2, Age="20", City="Laon", Country="France", Description = DescriptionClass.Line10},
				new Item { Id="99", FullName="Serge Surman", Gender=(GenderEnum) 2, Age="19", City="Itoman", Country="Japan", Description = DescriptionClass.Line2},
				new Item { Id="100", FullName="Fons Duplan", Gender=(GenderEnum) 2, Age="21", City="Gjinoc", Country="Kosovo", Description = DescriptionClass.Line5},

			};
		}
	}

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}