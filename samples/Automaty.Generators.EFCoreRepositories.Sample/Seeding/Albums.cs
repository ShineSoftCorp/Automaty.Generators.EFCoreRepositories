﻿namespace Automaty.Generators.EFCoreRepositories.Sample.Seeding
{
	using System.Collections.Generic;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	public static class Albums
	{
		public static IEnumerable<Album> Get(IDictionary<string, Genre> genres, IDictionary<string, Artist> artists)
		{
			string imgUrl = "~/Images/placeholder.png";

			Album[] albums =
			{
				new Album
				{
					Title = "The Best Of The Men At Work",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Men At Work"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "...And Justice For All",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "עד גבול האור",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["אריק אינשטיין"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Black Light Syndrome",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Terry Bozzio, Tony Levin & Steve Stevens"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "10,000 Days",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Tool"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "11i",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Supreme Beings of Leisure"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "1960",
					Genre = genres["Indie"],
					Price = 8.99M,
					Artist = artists["Soul-Junk"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "4x4=12 ",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["deadmau5"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Copland Celebration, Vol. I",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["London Symphony Orchestra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Lively Mind",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Paul Oakenfold"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Matter of Life and Death",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Real Dead One",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Real Live One",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Rush of Blood to the Head",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Coldplay"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Soprano Inspired",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Britten Sinfonia, Ivor Bolton & Lesley Garrett"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A Winter Symphony",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Abbey Road",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Beatles"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ace Of Spades",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Motörhead"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Achtung Baby",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Acústico MTV",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Os Paralamas Do Sucesso"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Adams, John: The Chairman Dances",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Edo de Waart & San Francisco Symphony"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Adrenaline",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deftones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ænima",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Tool"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Afrociberdelia",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Chico Science & Nação Zumbi"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "After the Goldrush",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Neil Young"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Airdrawn Dagger",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Sasha"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Album Title Goes Here",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["deadmau5"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Alcohol Fueled Brewtality Live! [Disc 1]",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Black Label Society"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Alcohol Fueled Brewtality Live! [Disc 2]",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Black Label Society"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Alive 2007",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Daft Punk"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "All I Ask of You",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Amen (So Be It)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Paddy Casey"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Animal Vehicle",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["The Axis of Awesome"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ao Vivo [IMPORT]",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Zeca Pagodinho"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Apocalyptic Love",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Slash"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Appetite for Destruction",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Guns N' Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Are You Experienced?",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Jimi Hendrix"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Arquivo II",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Os Paralamas Do Sucesso"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Arquivo Os Paralamas Do Sucesso",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Os Paralamas Do Sucesso"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "A-Sides",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Soundgarden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Audioslave",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Audioslave"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Automatic for the People",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["R.E.M."],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Axé Bahia 2001",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Various Artists"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Babel",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Mumford & Sons"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bach: Goldberg Variations",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Wilhelm Kempff"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bach: The Brandenburg Concertos",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Orchestra of The Age of Enlightenment"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bach: The Cello Suites",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Yo-Yo Ma"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bach: Toccata & Fugue in D Minor",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Ton Koopman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bad Motorfinger",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Soundgarden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Balls to the Wall",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Accept"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Banadeek Ta'ala",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Amr Diab"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Barbie Girl",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Aqua"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bark at the Moon (Remastered)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bartok: Violin & Viola Concertos",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Yehudi Menuhin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Barulhinho Bom",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Marisa Monte"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "BBC Sessions [Disc 1] [Live]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "BBC Sessions [Disc 2] [Live]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Be Here Now",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Oasis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bedrock 11 Compiled & Mixed",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["John Digweed"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Berlioz: Symphonie Fantastique",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Michael Tilson Thomas"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Beyond Good And Evil",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Cult"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Big Bad Wolf ",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Armand Van Helden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Big Ones",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Aerosmith"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Black Album",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Black Sabbath Vol. 4 (Remaster)",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Black Sabbath"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Black Sabbath",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Black Sabbath"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Black",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Blackwater Park",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Opeth"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Blizzard of Ozz",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Blood",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["In This Moment"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Blue Moods",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Incognito"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Blue",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Weezer"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bongo Fury",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Frank Zappa & Captain Beefheart"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Boys & Girls",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Alabama Shakes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Brave New World",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "B-Sides 1980-1990",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Bunkka",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Paul Oakenfold"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "By The Way",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Red Hot Chili Peppers"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cake: B-Sides and Rarities",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Cake"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Californication",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Red Hot Chili Peppers"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Carmina Burana",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Boston Symphony Orchestra & Seiji Ozawa"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Carried to Dust (Bonus Track Version)",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Calexico"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Carry On",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Chris Cornell"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cássia Eller - Sem Limite [Disc 1]",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Cássia Eller"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chemical Wedding",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Bruce Dickinson"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chill: Brazil (Disc 1)",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Marcos Valle"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chill: Brazil (Disc 2)",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Antônio Carlos Jobim"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chocolate Starfish And The Hot Dog Flavored Water",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Limp Bizkit"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chronicle, Vol. 1",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Creedence Clearwater Revival"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Chronicle, Vol. 2",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Creedence Clearwater Revival"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ciao, Baby",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["TheStart"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cidade Negra - Hits",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Cidade Negra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Classic Munkle: Turbo Edition",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Munkle"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Classics: The Best of Sarah Brightman",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Coda",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Come Away With Me",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Norah Jones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Come Taste The Band",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Comfort Eagle",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Cake"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Common Reaction",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Uh Huh Her "],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Compositores",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["O Terço"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Contraband",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Velvet Revolver"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Core",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Stone Temple Pilots"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cornerstone",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Styx"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cosmicolor",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["M-Flo"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Cross",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Justice"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Culture of Fear",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Thievery Corporation"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Da Lama Ao Caos",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Chico Science & Nação Zumbi"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Dakshina",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Deva Premal"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Dark Side of the Moon",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pink Floyd"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Death Magnetic",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Deep End of Down",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Above the Fold"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Deep Purple In Rock",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Deixa Entrar",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Falamansa"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Deja Vu",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Crosby, Stills, Nash, and Young"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Di Korpu Ku Alma",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Lura"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Diary of a Madman (Remastered)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Diary of a Madman",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Dirt",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Alice in Chains"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Diver Down",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Van Halen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Djavan Ao Vivo - Vol. 02",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Djavan"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Djavan Ao Vivo - Vol. 1",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Djavan"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Drum'n'bass for Papa",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Plug"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Duluth",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Trampled By Turtles"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Dummy",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Portishead"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Duos II",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Luciana Souza/Romero Lubambo"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Earl Scruggs and Friends",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Earl Scruggs"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Eden",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "El Camino",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Black Keys"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Elegant Gypsy",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Al di Meola"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Elements Of Life",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Tiësto"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Elis Regina-Minha História",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Elis Regina"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Emergency On Planet Earth",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Jamiroquai"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Emotion",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Papa Wemba"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "English Renaissance",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["The King's Singers"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Every Kind of Light",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Posies"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Faceless",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Godsmack"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Facelift",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Alice in Chains"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Fair Warning",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Van Halen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Fear of a Black Planet",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Public Enemy"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Fear Of The Dark",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Feels Like Home",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Norah Jones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Fireball",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Fly",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "For Those About To Rock We Salute You",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["AC/DC"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Four",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Blues Traveler"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Frank",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Amy Winehouse"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Further Down the Spiral",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Nine Inch Nails"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Garage Inc. (Disc 1)",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Garage Inc. (Disc 2)",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Garbage",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Garbage"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Good News For People Who Love Bad News",
					Genre = genres["Indie"],
					Price = 8.99M,
					Artist = artists["Modest Mouse"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Gordon",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Barenaked Ladies"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Górecki: Symphony No. 3",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Adrian Leaper & Doreen de Feis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Hits I",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Queen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Hits II",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Queen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Hits",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Duck Sauce"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Hits",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Lenny Kravitz"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Hits",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Lenny Kravitz"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greatest Kiss",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Kiss"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Greetings from Michigan",
					Genre = genres["Indie"],
					Price = 8.99M,
					Artist = artists["Sufjan Stevens"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Group Therapy",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Above & Beyond"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Handel: The Messiah (Highlights)",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Scholars Baroque Ensemble"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Haydn: Symphonies 99 - 104",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Royal Philharmonic Orchestra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Heart of the Night",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Spyro Gyra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Heart On",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Eagles of Death Metal"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Holy Diver",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Dio"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Homework",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Daft Punk"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Hot Rocks, 1964-1971 (Disc 1)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Rolling Stones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Houses Of The Holy",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "How To Dismantle An Atomic Bomb",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Human",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Projected"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Hunky Dory",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["David Bowie"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Hymns",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Projected"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Hysteria",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Def Leppard"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Absentia",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Porcupine Tree"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Between",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Paul Van Dyk"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Rainbows",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Radiohead"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Step",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Stevie Ray Vaughan & Double Trouble"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In the court of the Crimson King",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["King Crimson"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Through The Out Door",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Your Honor [Disc 1]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Foo Fighters"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "In Your Honor [Disc 2]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Foo Fighters"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Indestructible",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Rancid"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Infinity",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Journey"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Into The Light",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["David Coverdale"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Introspective",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Pet Shop Boys"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Iron Maiden",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "ISAM",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Amon Tobin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "IV",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Jagged Little Pill",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Alanis Morissette"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Jagged Little Pill",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Alanis Morissette"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Jorge Ben Jor 25 Anos",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Jorge Ben"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Jota Quest-1995",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Jota Quest"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Kick",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["INXS"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Kill 'Em All",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Kind of Blue",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Miles Davis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "King For A Day Fool For A Lifetime",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Faith No More"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Kiss",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Carly Rae Jepsen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Last Call",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Cayouche"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Le Freak",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Chic"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Le Tigre",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Le Tigre"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Led Zeppelin I",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Led Zeppelin II",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Led Zeppelin III",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Let There Be Rock",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["AC/DC"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Little Earthquakes",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Tori Amos"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live [Disc 1]",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["The Black Crowes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live [Disc 2]",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["The Black Crowes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live After Death",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live At Donington 1992 (Disc 1)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live At Donington 1992 (Disc 2)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live on Earth",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["The Cat Empire"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Live On Two Legs [Live]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pearl Jam"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Living After Midnight",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Judas Priest"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Living",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Paddy Casey"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Load",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Love Changes Everything",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "MacArthur Park Suite",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Donna Summer"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Machine Head",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Magical Mystery Tour",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["The Beatles"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mais Do Mesmo",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Legião Urbana"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Maquinarama",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Skank"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Marasim",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Jagjit Singh"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mascagni: Cavalleria Rusticana",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["James Levine"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Master of Puppets",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mechanics & Mathematics",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Venus Hum"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mental Jewelry",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Live"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Metallics",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "meteora",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Linkin Park"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Meus Momentos",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Gonzaguinha"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mezmerize",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["System Of A Down"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mezzanine",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Massive Attack"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Miles Ahead",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Miles Davis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Milton Nascimento Ao Vivo",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Milton Nascimento"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Minas",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Milton Nascimento"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Minha Historia",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Chico Buarque"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Misplaced Childhood",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Marillion"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "MK III The Final Concerts [Disc 1]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Morning Dance",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Spyro Gyra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Motley Crue Greatest Hits",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Mötley Crüe"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Moving Pictures",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Rush"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mozart: Chamber Music",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Nash Ensemble"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Mozart: Symphonies Nos. 40 & 41",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Berliner Philharmoniker"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Murder Ballads",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Nick Cave and the Bad Seeds"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Music For The Jilted Generation",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["The Prodigy"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "My Generation - The Very Best Of The Who",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Who"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "My Name is Skrillex",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Skrillex"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Na Pista",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Cláudio Zoli"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Nevermind",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Nirvana"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "New Adventures In Hi-Fi",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["R.E.M."],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "New Divide",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Linkin Park"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "New York Dolls",
					Genre = genres["Punk"],
					Price = 8.99M,
					Artist = artists["New York Dolls"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "News Of The World",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Queen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Nielsen: The Six Symphonies",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Göteborgs Symfoniker & Neeme Järvi"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Night At The Opera",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Queen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Night Castle",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Trans-Siberian Orchestra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Nkolo",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Lokua Kanza"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "No More Tears (Remastered)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "No Prayer For The Dying",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "No Security",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Rolling Stones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "O Brother, Where Art Thou?",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Alison Krauss"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "O Samba Poconé",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Skank"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "O(+>",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Prince"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Oceania",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Smashing Pumpkins"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Off the Deep End",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Weird Al"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "OK Computer",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Radiohead"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Olodum",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Olodum"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "One Love",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["David Guetta"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Operation: Mindcrime",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Queensrÿche"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Opiate",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Tool"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Outbreak",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Dennis Chambers"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Pachelbel: Canon & Gigue",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["English Concert & Trevor Pinnock"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Paid in Full",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Eric B. and Rakim"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Para Siempre",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Vicente Fernandez"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Pause",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Four Tet"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Peace Sells... but Who's Buying",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Megadeth"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Physical Graffiti [Disc 1]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Physical Graffiti [Disc 2]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Physical Graffiti",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Piece Of Mind",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Pinkerton",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Weezer"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Plays Metallica By Four Cellos",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Apocalyptica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Pop",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Powerslave",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Prenda Minha",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Caetano Veloso"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Presence",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Pretty Hate Machine",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Nine Inch Nails"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Prisoner",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Jezabels"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Privateering",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Mark Knopfler"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Prokofiev: Romeo & Juliet",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Michael Tilson Thomas"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Prokofiev: Symphony No.1",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sergei Prokofiev & Yuri Temirkanov"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "PSY's Best 6th Part 1",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["PSY"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Purcell: The Fairy Queen",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["London Classical Players"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Purpendicular",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Purple",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Stone Temple Pilots"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Quanta Gente Veio Ver (Live)",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Gilberto Gil"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Quanta Gente Veio ver--Bônus De Carnaval",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Gilberto Gil"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Quiet Songs",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Aisha Duo"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Raices",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Los Tigres del Norte"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Raising Hell",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Run DMC"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Raoul and the Kings of Spain ",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Tears For Fears"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rattle And Hum",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Raul Seixas",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Raul Seixas"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Recovery [Explicit]",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Eminem"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Reign In Blood",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Slayer"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Relayed",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Yes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "ReLoad",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Respighi:Pines of Rome",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Eugene Ormandy"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Restless and Wild",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Accept"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Retrospective I (1974-1980)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Rush"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Revelations",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Audioslave"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Revolver",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Beatles"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ride the Lighting ",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ride The Lightning",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ring My Bell",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Anita Ward"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Riot Act",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pearl Jam"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rise of the Phoenix",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Before the Dawn"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rock In Rio [CD1]",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rock In Rio [CD2]",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rock In Rio [CD2]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Roda De Funk",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Funk Como Le Gusta"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Room for Squares",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["John Mayer"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Root Down",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Jimmy Smith"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rounds",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Four Tet"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rubber Factory",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Black Keys"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Rust in Peace",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Megadeth"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Sambas De Enredo 2001",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Various Artists"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Santana - As Years Go By",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Santana"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Santana Live",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Santana"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Saturday Night Fever",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Bee Gees"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Scary Monsters and Nice Sprites",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Skrillex"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Scheherazade",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Chicago Symphony Orchestra & Fritz Reiner"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "SCRIABIN: Vers la flamme",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Christopher O'Riley"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Second Coming",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Stone Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Serie Sem Limite (Disc 1)",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Tim Maia"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Serie Sem Limite (Disc 2)",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Tim Maia"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Serious About Men",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["The Rubberbandits"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Seventh Son of a Seventh Son",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Short Bus",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Filter"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Sibelius: Finlandia",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Berliner Philharmoniker"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Singles Collection",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["David Bowie"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Six Degrees of Inner Turbulence",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Dream Theater"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Slave To The Empire",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["T&N"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Slaves And Masters",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Slouching Towards Bethlehem",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Robert James"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Smash",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Offspring"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Something Special",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Dolly Parton"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Somewhere in Time",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Song(s) You Know By Heart",
					Genre = genres["Country"],
					Price = 8.99M,
					Artist = artists["Jimmy Buffett"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Sound of Music",
					Genre = genres["Punk"],
					Price = 8.99M,
					Artist = artists["Adicts"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "South American Getaway",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["The 12 Cellists of The Berlin Philharmonic"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Sozinho Remix Ao Vivo",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Caetano Veloso"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Speak of the Devil",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Spiritual State",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Nujabes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "St. Anger",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Metallica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Still Life",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Opeth"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Stop Making Sense",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Talking Heads"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Stormbringer",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Stranger than Fiction",
					Genre = genres["Punk"],
					Price = 8.99M,
					Artist = artists["Bad Religion"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Strauss: Waltzes",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Eugene Ormandy"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Supermodified",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Amon Tobin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Supernatural",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Santana"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Surfing with the Alien (Remastered)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Joe Satriani"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Switched-On Bach",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Wendy Carlos"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Symphony",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Szymanowski: Piano Works, Vol. 1",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Martin Roscoe"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Tchaikovsky: The Nutcracker",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["London Symphony Orchestra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ted Nugent",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Ted Nugent"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Teflon Don",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Rick Ross"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Tell Another Joke at the Ol' Choppin' Block",
					Genre = genres["Indie"],
					Price = 8.99M,
					Artist = artists["Danielson Famile"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Temple of the Dog",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Temple of the Dog"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Ten",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pearl Jam"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Texas Flood",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Stevie Ray Vaughan"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Battle Rages On",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Beast Live",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Paul D'Ianno"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best Of 1980-1990",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best of 1990–2000",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best of Beethoven",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Nicolaus Esterhazy Sinfonia"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best Of Billy Cobham",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Billy Cobham"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best of Ed Motta",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Ed Motta"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Best Of Van Halen, Vol. I",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Van Halen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Bridge",
					Genre = genres["R&B"],
					Price = 8.99M,
					Artist = artists["Melanie Fiona"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Cage",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Tygers of Pan Tang"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Chicago Transit Authority",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Chicago "],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Chronic",
					Genre = genres["Rap"],
					Price = 8.99M,
					Artist = artists["Dr. Dre"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Colour And The Shape",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Foo Fighters"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Crane Wife",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["The Decemberists"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Cream Of Clapton",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Eric Clapton"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Cure",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["The Cure"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Dark Side Of The Moon",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pink Floyd"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Divine Conspiracy",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Epica"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Doors",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Doors"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Dream of the Blue Turtles",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Sting"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Essential Miles Davis [Disc 1]",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Miles Davis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Essential Miles Davis [Disc 2]",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Miles Davis"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Final Concerts (Disc 2)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deep Purple"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Final Frontier",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Head and the Heart",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Head and the Heart"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Joshua Tree",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Last Night of the Proms",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["BBC Concert Orchestra"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Lumineers",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Lumineers"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Number of The Beast",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Number of The Beast",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Police Greatest Hits",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Police"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Song Remains The Same (Disc 1)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Song Remains The Same (Disc 2)",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Southern Harmony and Musical Companion",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["The Black Crowes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Spade",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Butch Walker & The Black Widows"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Stone Roses",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Stone Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Suburbs",
					Genre = genres["Indie"],
					Price = 8.99M,
					Artist = artists["Arcade Fire"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Three Tenors Disc1/Disc2",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Carreras, Pavarotti, Domingo"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Trees They Grow So High",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The Wall",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pink Floyd"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "The X Factor",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Them Crooked Vultures",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Them Crooked Vultures"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "This Is Happening",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["LCD Soundsystem"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Thunder, Lightning, Strike",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Go! Team"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Time to Say Goodbye",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sarah Brightman"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Time, Love & Tenderness",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["Michael Bolton"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Tomorrow Starts Today",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Mobile"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Tribute",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Ozzy Osbourne"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Tuesday Night Music Club",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Sheryl Crow"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Umoja",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["BLØF"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Under the Pink",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Tori Amos"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Undertow",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Tool"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Un-Led-Ed",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Dread Zeppelin"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Unplugged [Live]",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Kiss"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Unplugged",
					Genre = genres["Blues"],
					Price = 8.99M,
					Artist = artists["Eric Clapton"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Unplugged",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Eric Clapton"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Untrue",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Burial"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Use Your Illusion I",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Guns N' Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Use Your Illusion II",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Guns N' Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Use Your Illusion II",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Guns N' Roses"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Van Halen III",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Van Halen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Van Halen",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Van Halen"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Version 2.0",
					Genre = genres["Alternative"],
					Price = 8.99M,
					Artist = artists["Garbage"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Vinicius De Moraes",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Vinícius De Moraes"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Virtual XI",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Iron Maiden"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Voodoo Lounge",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Rolling Stones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Vozes do MPB",
					Genre = genres["Latin"],
					Price = 8.99M,
					Artist = artists["Various Artists"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Vs.",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pearl Jam"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Wagner: Favourite Overtures",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Sir Georg Solti & Wiener Philharmoniker"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Walking Into Clarksdale",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Page & Plant"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Wapi Yo",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Lokua Kanza"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "War",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Warner 25 Anos",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Antônio Carlos Jobim"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Wasteland R&Btheque",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Raunchy"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Watermark",
					Genre = genres["Electronic"],
					Price = 8.99M,
					Artist = artists["Enya"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "We Were Exploding Anyway",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["65daysofstatic"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Weill: The Seven Deadly Sins",
					Genre = genres["Classical"],
					Price = 8.99M,
					Artist = artists["Orchestre de l'Opéra de Lyon"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "White Pony",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Deftones"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Who's Next",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["The Who"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Wish You Were Here",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Pink Floyd"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "With Oden on Our Side",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Amon Amarth"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Worlds",
					Genre = genres["Jazz"],
					Price = 8.99M,
					Artist = artists["Aaron Goldberg"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Worship Music",
					Genre = genres["Metal"],
					Price = 8.99M,
					Artist = artists["Anthrax"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "X&Y",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Coldplay"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Xinti",
					Genre = genres["World"],
					Price = 8.99M,
					Artist = artists["Sara Tavares"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Yano",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Yano"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Yesterday Once More Disc 1/Disc 2",
					Genre = genres["Pop"],
					Price = 8.99M,
					Artist = artists["The Carpenters"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Zooropa",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["U2"],
					AlbumArtUrl = imgUrl
				},
				new Album
				{
					Title = "Zoso",
					Genre = genres["Rock"],
					Price = 8.99M,
					Artist = artists["Led Zeppelin"],
					AlbumArtUrl = imgUrl
				}
			};

			return albums;
		}
	}
}