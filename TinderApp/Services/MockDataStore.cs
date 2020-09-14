using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TinderApp.Models;

namespace TinderApp.Services
{
    public class MockDataStore : IDataStore<Contact>
    {
        readonly List<Contact> contacts;

        public MockDataStore()
        {
			contacts = new List<Contact>()
			{
				new Contact { Id="0", FullName="Marget Bellsham", Gender=(GenderEnum) 2, Age=23, City="Hòa Bình", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="1", FullName="Merissa Bellsham", Gender=(GenderEnum) 2, Age=23, City="Hòa Bình", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="2", FullName="Reamonn Kellaway", Gender=(GenderEnum) 2, Age=18, City="Stará Huť", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="3", FullName="Prentice Fattorini", Gender=(GenderEnum) 2, Age=25, City="Peicheng", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="4", FullName="Rutter Search", Gender=(GenderEnum) 2, Age=23, City="Xinzhou", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="5", FullName="Marget Curteis", Gender=(GenderEnum) 1, Age=19, City="Mīrābād", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="6", FullName="Arlee Corps", Gender=(GenderEnum) 1, Age=21, City="Ḩammām Wāşil", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="7", FullName="Dre Mullane", Gender=(GenderEnum) 0, Age=18, City="Golcowa", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="8", FullName="Daisey Holdforth", Gender=(GenderEnum) 2, Age=22, City="Flying Fish Cove", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="9", FullName="Gerhardine Danby", Gender=(GenderEnum) 2, Age=23, City="Patrol", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="10", FullName="Morissa Aulton", Gender=(GenderEnum) 2, Age=24, City="Chernigovka", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="11", FullName="Valeria Heathorn", Gender=(GenderEnum) 0, Age=24, City="Pustá Polom", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="12", FullName="Frans Woodyeare", Gender=(GenderEnum) 2, Age=20, City="Guluoshan", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="13", FullName="Noach Krzyzowski", Gender=(GenderEnum) 2, Age=22, City="Oslo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="14", FullName="Elmo Apark", Gender=(GenderEnum) 1, Age=19, City="Adassil", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="15", FullName="Ernestus Van T'Hoog", Gender=(GenderEnum) 2, Age=18, City="Labuhanlalar", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="16", FullName="Lebbie Colhoun", Gender=(GenderEnum) 2, Age=20, City="Tanjay", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="17", FullName="Moyra Sirey", Gender=(GenderEnum) 1, Age=23, City="Gelatik", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="18", FullName="Dennis Bruckmann", Gender=(GenderEnum) 0, Age=18, City="Divo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="19", FullName="Bryana Sargeant", Gender=(GenderEnum) 2, Age=21, City="Xilian", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="20", FullName="Carmella Cromleholme", Gender=(GenderEnum) 2, Age=23, City="Hexi",SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="21", FullName="Torey Silverman", Gender=(GenderEnum) 1, Age=20, City="Uglegorsk", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="22", FullName="Tabby Matthew", Gender=(GenderEnum) 1, Age=24, City="Nynäshamn", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="23", FullName="Ulberto Peach", Gender=(GenderEnum) 0, Age=20, City="Mūsa Khel Bāzār", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="24", FullName="Eda Balmann", Gender=(GenderEnum) 2, Age=21, City="Arzakan", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="25", FullName="Lynn Fisby", Gender=(GenderEnum) 2, Age=24, City="Loei", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="26", FullName="Dyna Haslam", Gender=(GenderEnum) 2, Age=19, City="Yurla", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="27", FullName="Sibbie Peace", Gender=(GenderEnum) 2, Age=18, City="Krajan Gading", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="28", FullName="Farley Sedgeman", Gender=(GenderEnum) 2, Age=25, City="Vysotsk", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="29", FullName="Nissy Pearn", Gender=(GenderEnum) 0, Age=18, City="Smiths Falls", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="30", FullName="Ramona Esilmon", Gender=(GenderEnum) 2, Age=21, City="Siuna", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="31", FullName="Eydie Jann", Gender=(GenderEnum) 0, Age=20, City="Reshetnikovo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="32", FullName="Thorin Gurge", Gender=(GenderEnum) 2, Age=23, City="Mauponggo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="33", FullName="Judye Bakeup", Gender=(GenderEnum) 1, Age=18, City="Inawashiro", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="34", FullName="Yorgos Sidgwick", Gender=(GenderEnum) 0, Age=20, City="Pamedilan", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="35", FullName="Steven Golland", Gender=(GenderEnum) 1, Age=20, City="Oslo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="36", FullName="Bradney Scandwright", Gender=(GenderEnum) 2, Age=19, City="Žďár nad Sázavou", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="37", FullName="Aleksandr Kirsche", Gender=(GenderEnum) 0, Age=18, City="Seredka", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="38", FullName="Hewett Freestone", Gender=(GenderEnum) 0, Age=21, City="Donostia-San Sebastian", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="39", FullName="Cammy Stanyard", Gender=(GenderEnum) 2, Age=24, City="Vũng Tàu", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="40", FullName="Joyce Semarke", Gender=(GenderEnum) 1, Age=25, City="Toshkivka", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="41", FullName="Allen Boydon", Gender=(GenderEnum) 2, Age=21, City="Farranacoush", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="42", FullName="Rollins Coraini", Gender=(GenderEnum) 1, Age=24, City="Ubonratana", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="43", FullName="Romain Berrington", Gender=(GenderEnum) 2, Age=18, City="Ogawa", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="44", FullName="Tamqrah Freiberg", Gender=(GenderEnum) 1, Age=21, City="Santa Bernardina", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="45", FullName="Michel Kiff", Gender=(GenderEnum) 0, Age=19, City="Novoalekseyevskaya", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="46", FullName="Hamilton Crampsey", Gender=(GenderEnum) 0, Age=21, City="Thionville",SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="47", FullName="Homerus Gass", Gender=(GenderEnum) 1, Age=19, City="Tashla", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="48", FullName="Cahra Scarlon", Gender=(GenderEnum) 0, Age=23, City="Jönköping", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="49", FullName="Augusta Sollner", Gender=(GenderEnum) 2, Age=20, City="Gwadabawa", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="50", FullName="Paige Kmietsch", Gender=(GenderEnum) 1, Age=19, City="Norzagaray", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="51", FullName="Leanor Quiddington", Gender=(GenderEnum) 1, Age=20, City="Skënderbegas", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="52", FullName="Addi Fitzgerald", Gender=(GenderEnum) 1, Age=24, City="Rekovac", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="53", FullName="Prent Foulis", Gender=(GenderEnum) 1, Age=18, City="Vorontsovka", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="54", FullName="Fran Bleakley", Gender=(GenderEnum) 2, Age=24, City="Hanna", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="55", FullName="Holmes Gamil", Gender=(GenderEnum) 2, Age=18, City="Chatou", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="56", FullName="Sephira Swaby", Gender=(GenderEnum) 2, Age=23, City="Karanggeneng", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="57", FullName="Alida Woodrup", Gender=(GenderEnum) 2, Age=20, City="Homeyo", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="58", FullName="Bertie Goodin", Gender=(GenderEnum) 1, Age=20, City="Buenavista", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="59", FullName="Alisander Kier", Gender=(GenderEnum) 1, Age=22, City="Komenda", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="60", FullName="Manda Lampart", Gender=(GenderEnum) 2, Age=21, City="Dongbang", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="61", FullName="Doll Hardwidge", Gender=(GenderEnum) 2, Age=21, City="Krasnoye", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="62", FullName="Luca Mulqueen", Gender=(GenderEnum) 2, Age=20, City="Alvide", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="63", FullName="Gillie Wellbank", Gender=(GenderEnum) 2, Age=23, City="Dizangué", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="64", FullName="Jesus Dalgliesh", Gender=(GenderEnum) 2, Age=22, City="Tawun", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="65", FullName="Millicent Pietron", Gender=(GenderEnum) 2, Age=19, City="Tegalgede", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="66", FullName="Dyan Hindrick", Gender=(GenderEnum) 2, Age=24, City="Nîmes", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="67", FullName="Charlena Keetch", Gender=(GenderEnum) 0, Age=22, City="Putang", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="68", FullName="Lorant Crimes", Gender=(GenderEnum) 2, Age=24, City="Quvasoy", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="69", FullName="Emalia Cadwell", Gender=(GenderEnum) 2, Age=25, City="Shemonaīkha", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="70", FullName="Geri Hobden", Gender=(GenderEnum) 2, Age=18, City="Itupeva", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="71", FullName="Chariot MacFadzan", Gender=(GenderEnum) 1, Age=21, City="Wuxi", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="72", FullName="Margarethe Spelling", Gender=(GenderEnum) 1, Age=20, City="Zhonghe", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="73", FullName="Maryanne Santacrole", Gender=(GenderEnum) 2, Age=18, City="Bielawy", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="74", FullName="Dayna Douglass", Gender=(GenderEnum) 2, Age=20, City="Modot", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[3], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="75", FullName="Fred Willerson", Gender=(GenderEnum) 2, Age=18, City="Falun", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="76", FullName="Diannne Wetherburn", Gender=(GenderEnum) 2, Age=23, City="Mississauga", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="77", FullName="Gill Bernhardt", Gender=(GenderEnum) 2, Age=22, City="Tacoma", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="78", FullName="Philippine Mintrim", Gender=(GenderEnum) 0, Age=24, City="Kadukaung", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="79", FullName="Dieter Fullager", Gender=(GenderEnum) 2, Age=21, City="Châteauroux", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="80", FullName="Rolland Felix", Gender=(GenderEnum) 2, Age=22, City="Yekimovichi", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="81", FullName="Agustin Chatin", Gender=(GenderEnum) 0, Age=22, City="Şaḩneh", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="82", FullName="Stacee Sabbin", Gender=(GenderEnum) 2, Age=19, City="Banjar Jagasatru", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="83", FullName="Oralla Newson", Gender=(GenderEnum) 2, Age=20, City="Fushë-Muhurr", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="84", FullName="Morgana Brimmell", Gender=(GenderEnum) 1, Age=25, City="Qarāwul", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="85", FullName="Sherilyn Caswell", Gender=(GenderEnum) 2, Age=23, City="Makariv", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="86", FullName="Halsey Yaakov", Gender=(GenderEnum) 0, Age=18, City="Turkestan", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="87", FullName="Idalina Baleine", Gender=(GenderEnum) 0, Age=19, City="Kushiro", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[13]},
				new Contact { Id="88", FullName="Ardyce Humes", Gender=(GenderEnum) 0, Age=23, City="Karlstad", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[0]},
				new Contact { Id="89", FullName="Joby Zmitruk", Gender=(GenderEnum) 1, Age=24, City="Quinta da Torre", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[1]},
				new Contact { Id="90", FullName="Jilli Dieton", Gender=(GenderEnum) 2, Age=24, City="Caieiras", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[8], Image=ContactHelper.ImageNameConstants[2]},
				new Contact { Id="91", FullName="Darbie Balnave", Gender=(GenderEnum) 2, Age=21, City="Kertayuga", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[3]},
				new Contact { Id="92", FullName="Robbyn Tayt", Gender=(GenderEnum) 0, Age=20, City="Tamahú", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[7], Image=ContactHelper.ImageNameConstants[4]},
				new Contact { Id="93", FullName="Ardath Fayers", Gender=(GenderEnum) 2, Age=18, City="Zhaocun", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[2], Image=ContactHelper.ImageNameConstants[5]},
				new Contact { Id="94", FullName="Lazarus Dulany", Gender=(GenderEnum) 0, Age=22, City="Brangsi", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[5], Image=ContactHelper.ImageNameConstants[6]},
				new Contact { Id="95", FullName="Lindsy Delgardo", Gender=(GenderEnum) 1, Age=24, City="Booterstown", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[7]},
				new Contact { Id="96", FullName="Laurens Hun", Gender=(GenderEnum) 2, Age=21, City="Opatowiec", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[6], Image=ContactHelper.ImageNameConstants[8]},
				new Contact { Id="97", FullName="Ruthanne Loeber", Gender=(GenderEnum) 1, Age=20, City="Puyan", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[0], Image=ContactHelper.ImageNameConstants[9]},
				new Contact { Id="98", FullName="Joe Dotterill", Gender=(GenderEnum) 2, Age=20, City="Laon", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[9], Image=ContactHelper.ImageNameConstants[10]},
				new Contact { Id="99", FullName="Serge Surman", Gender=(GenderEnum) 2, Age=19, City="Itoman", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[1], Image=ContactHelper.ImageNameConstants[11]},
				new Contact { Id="100", FullName="Fons Duplan", Gender=(GenderEnum) 2, Age=21, City="Gjinoc", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[12]},
				new Contact { Id="101", FullName="John Doe", Gender=GenderEnum.Male, Age=21, City="London", SwipeState=SwipeStates.Unseen, Description = ContactHelper.DescriptionConstants[4], Image=ContactHelper.ImageNameConstants[13]}
			};
		}
        public async Task<bool> UpdateItemAsync(Contact item)
        {
            var oldContact = contacts.Where((Contact arg) => arg.Id == item.Id).FirstOrDefault();
            contacts.Remove(oldContact);
            contacts.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<Contact> GetItemAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Contact>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
        }
		public async Task<List<Contact>> GetUnseenItemsAsync(bool forceRefresh = false)
		{

			List<Contact> allUnseenItems = contacts.FindAll(c => c.SwipeState == SwipeStates.Unseen);
			return await Task.FromResult(allUnseenItems);
		}
	}
}

