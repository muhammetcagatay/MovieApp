﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProgrammingMovie.Data;

namespace WebProgrammingMovie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220611105234_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Actor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorName = "Johnny Depp",
                            Age = 45,
                            MovieId = 1,
                            PhotoURL = "https://tr.web.img4.acsta.net/pictures/22/04/18/16/11/4406324.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ActorName = "Geoffrey Rush",
                            Age = 70,
                            MovieId = 1,
                            PhotoURL = "https://tr.web.img3.acsta.net/c_310_420/pictures/15/11/18/10/19/300806.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ActorName = "Ashley Greene",
                            Age = 35,
                            MovieId = 2,
                            PhotoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Ashley_Greene_2012.jpg/800px-Ashley_Greene_2012.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ActorName = "Emmanuel Imani",
                            Age = 30,
                            MovieId = 2,
                            PhotoURL = "https://www.themoviedb.org/t/p/w500/gTYTHVIfv1HMr6h1gtLoACH7l17.jpg"
                        },
                        new
                        {
                            Id = 5,
                            ActorName = "Corey Hawkins",
                            Age = 32,
                            MovieId = 3,
                            PhotoURL = "https://images.mubicdn.net/images/cast_member/473019/cache-239998-1599533284/image-w856.jpg?size=800x"
                        },
                        new
                        {
                            Id = 6,
                            ActorName = "Sophie Turner",
                            Age = 26,
                            MovieId = 3,
                            PhotoURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e8/Sophie_Turner_%2840553145603%29_%28cropped%29.jpg/800px-Sophie_Turner_%2840553145603%29_%28cropped%29.jpg"
                        },
                        new
                        {
                            Id = 7,
                            ActorName = "Dominic Andersen",
                            Age = 26,
                            MovieId = 4,
                            PhotoURL = "https://m.media-amazon.com/images/M/MV5BMDgyM2M4OTMtY2Y5Ni00NjZiLWJlNmQtNmJhNmJmZGNlNjRjXkEyXkFqcGdeQXVyNjYzNzE0Mzk@._V1_UY1200_CR585,0,630,1200_AL_.jpg"
                        },
                        new
                        {
                            Id = 8,
                            ActorName = "Jennifer Matter",
                            Age = 42,
                            MovieId = 4,
                            PhotoURL = "https://www.themoviedb.org/t/p/original/e7LqKoP0B02v8VL0t7DBcrxn0Mm.jpg"
                        });
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Aksiyon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Macera"
                        });
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirectorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Director");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorName = "Gore Verbinski"
                        },
                        new
                        {
                            Id = 2,
                            DirectorName = "James Nunn"
                        },
                        new
                        {
                            Id = 3,
                            DirectorName = "Mark Pellington"
                        },
                        new
                        {
                            Id = 4,
                            DirectorName = "Bill Thomas"
                        });
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<string>("DetailPhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DirectorId")
                        .HasColumnType("int");

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<double>("IMDB")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderPhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DirectorId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Country = 2,
                            DetailPhotoURL = "https://upload.wikimedia.org/wikipedia/tr/thumb/e/ea/Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg/800px-Karayip_Korsanlar%C4%B1_Salazar%E2%80%99%C4%B1n_%C4%B0ntikam%C4%B1_T%C3%BCrk%C3%A7e_Afi%C5%9F.jpg",
                            DirectorId = 1,
                            Duration = 2.3999999999999999,
                            IMDB = 8.5999999999999996,
                            Name = "Karayip Korsanları 1",
                            ReleaseDate = new DateTime(2022, 6, 11, 13, 52, 33, 747, DateTimeKind.Local).AddTicks(3801),
                            Review = "Valinin kızı Elizabeth Swann, bir korsan olan Kaptan Barbossa tarafından kaçırılır. Başka bir korsan Jack Sparrow, Elizabethin çocukluk arkadaşı Will Turner ile işbirliği yaparak, kızı kurtarmaya çalışır. Peşine düştükleri korsanların ise gücünü ayışığından alan bir lanetleri vardır. Yaşam ile ölüm arasındaki sınırı aşmak ve güçlerine kavuşmak için kaçırdıkları genç kadını kullanmak istemektedirler.",
                            SliderPhotoURL = "https://i.pinimg.com/originals/87/a0/92/87a092260dd800b76f1ac6343f8d7fae.jpg",
                            View = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Country = 2,
                            DetailPhotoURL = "https://img.fullhdfilmizlesene.pw/poster/izle/one-shot-67638.jpg",
                            DirectorId = 2,
                            Duration = 2.0,
                            IMDB = 7.7999999999999998,
                            Name = "Tek Atış",
                            ReleaseDate = new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8065),
                            Review = "The Wheel of Time dizisinde ve Hold the Dark filminde oynayan Emmanuel Imani, Norveç yapımı Exit dizisinde oynayan Dino Kelly, Limehouse'un Gizemli Cinayetleri filminde oynayan Jack Parr gibi isimleri izliyoruz.Filmin yönetmeni Yeşil Sokak Holiganları 3: Asla Pes Etme filminin yönetmeni olan James Nunn’dır.James Nunn aynı zamandaki One Shot filminin iki senaristinden de birisidir.Senaryodaki diğer isim ise kısa metrajlı Bricks filminin senaristi olan Jamie Russell’dir.Aksiyon ve gerilim türlerine giren film şu anda 5.5 gibi bir IMDB puanına sahiptir.Film 5 Kasım 2021 tarihinde vizyona girmiştir.",
                            SliderPhotoURL = "https://metadata-static.plex.tv/5/gracenote/5ae29da9ddfaa3545a845cebd3658cb8.jpg",
                            View = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Country = 3,
                            DetailPhotoURL = "https://m.media-amazon.com/images/M/MV5BYjFhZGRiZWUtMmFlYi00MDkwLWFjYTMtYzVhZmQ3ZmUwN2I3XkEyXkFqcGdeQXVyMDA4NzMyOA@@._V1_.jpg",
                            DirectorId = 3,
                            Duration = 1.2,
                            IMDB = 6.7999999999999998,
                            Name = "Survive",
                            ReleaseDate = new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8081),
                            Review = "Jane ve Paul henüz birbirlerini tanımasalar da yok yakın bir zamanda birlikte oldukça zorlu bir zaman geçirecek olan kişilerdir. Survive isimli 4k film formatlı film ise Jane ve Paul isimli bu iki yabancının birlikte atlatmaya çalıştıkları korkunç bir durumu anlatmaktadır. Jane kendini psikiyatri kliniğine bir hasta olarak bulduğu zaman kimseyle henüz konuşmaya başlamamıştır.Terapisti ise başından her ne geçtiyse anlatması ve bu hislerini hafifletmesi için sürekli olarak Jane’e cesaret vermektedir.Bir gün ise Jane artık dayanamaz ve neden bu klinikte olduğunu tüm terapi grubuna anlatmaya başlar.Jane kendi hayatına bakarken günlerden bir gün uçakla uzak bir bölgeye gitmesi gerektiğinde herkes gibi uçağa binmiş ve rahatlamıştır.Dolu olan yolcu uçağı bir süre sorunsuz uçtuktan sonra ani bir şekilde denesini kaybetmeye başlar ve hızlı bir şekilde de tam olarak neresi olduğu bilinmeyen bir bölgeye çakılır.İşin tuhaf tarafı ise uçak çakıldıktan sonra Jane dışında sadece Paul adındaki bir adam hayatta kalmıştır.Jane ve Paul başta olayın şoku yüzünden anlaşamasalar da sonrasında eğer bu korkunç bölgeden kurtulmak istiyorlarsa birlikte hareket etmeleri gerektiğini anlarlar.Çünkü bulundukları bölge korkunç bir şekilde soğuk olan ve dağların arasında kalmış kar ve tipinin bir an bile kesilmediği bir bölgedir.Türkçe dublajıyla da hazırlanan bu muhteşem macera filminde Mark Pellington yapımın yönetmen koltuğundaki isimdir.Gerilimi dram ile muhteşem bir şekilde sunan filmin senaryosu ise Alex Morel’in kitabından Richard Abate ile Jeremy Ungar tarafından hazırlanmıştır.Soluk soluğa izleyeceğiniz filmin başrol oyuncu kadrosunu ise Sophie Turner ile Corey Hawkins isimleri oluşturmaktadır.Acaba nedene tüm uçaktan Jane ve Paul hayatta kalan iki kişidir ? Jane ve Paul nerede olduklarını bile henüz bulamazken nasıl hayatta kalmayı başaracaklardır ? Jane eğer olay sonrası psikiyatri kliniğinde ise Paul nerededir ? Yoksa Paul bu korkunç olaydan sağ çıkamamış mıdır ? ",
                            SliderPhotoURL = "https://flxt.tmsimg.com/assets/p18077051_b_h10_ad.jpg",
                            View = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Country = 1,
                            DetailPhotoURL = "https://img.yts.mx/assets/images/movies/the_adventures_of_maid_marian_2022/large-cover.jpg",
                            DirectorId = 4,
                            Duration = 1.8,
                            IMDB = 7.5,
                            Name = "The Adventures of Maid Marian",
                            ReleaseDate = new DateTime(2022, 6, 11, 13, 52, 33, 748, DateTimeKind.Local).AddTicks(8084),
                            Review = "Sadece 4k film formatıyla değil aynı zamanda Türkçe dublajıyla da siz değerli takipçilerimiz için hazırladığımız The Adventures of Maid Marian isimi macera dolu filmin hem yönetmen hem de senarist koltuğundaki isim Bill Thomas’dır. Marian ismindeki zorlu bir kadının başından geçen tehlike dolu maceralara odaklanan filmde Sophie Craig ile Lainy Boyle ve de Jennifer Matter isimleri de yapımın başrol oyuncu kadrosundaki simalardır.Marian başını beladan kurtarmak ve dikkat çekmemek için her ne kadar tam üç yıl boyunca bir manastırda saklanmış olsa da Marian için tehlikelerle dolu zaman henüz gelmemiştir.Her şeyin durulduğunu zanneden Marian bir anda Aslan Yürekli Richard’ın öldüğünü öğrenir ve bu haber de Marian için sevgilisi olan Robin’in yakında döneceği anlamına gelmektedir.Bu haber üzerine Marian artık saklanmanın bir anlamı kalmadığını düşünür ve hemen üç yıllık manastırından ayrılır.Fakat Marian her şeyi yerli yerinde bulacağını düşünürken bir zamanlar toplumda bir saygınlığı olan ancak artık hiçbir değeri olmayan şerif William De Wendenal’ın da sürgünden döndüğünü anlar.William De Wendenal’ın aklında ise sadece intikam dolu yer almaktadır.Bunu az çok bilen Marian ise her şeye hazırlıklı olması gerektiğini anlar.Fakat Marian sonunda sevgilisi Robin ile buluşur ve birlikte kaçmaya başlarlar.Bu sırada pusuya düşen Marian ile sevgilisi Robin hayatları adına bir savaşa girişirler ancak bu savaşın sonunda yaralanan taraf Robin olur.Ancak Marian buna rağmen sevgilisini ölüme terk etmez ve onu da yanına alarak ormanın derin noktalarına doğru sevgilisi ile birlikte kaçmaya başlar.Ama Marian için bu hiç de kolay olmayacaktır.Çünkü yardım alacak hiçbir yer yokken ve peşlerinde de zalim paralı askerler onları takip ederken Marian bir yandan da ağır bir şekilde yaralanmış olan sevgilisi Robin’i hayatta tutmalıdır.Bakalım Marian bunca zorluğa rağmen sevgilisi ile mutlu bir hayata kavuşabilecek midir ? ",
                            SliderPhotoURL = "https://i.ytimg.com/vi/cuET_yYoFk0/maxresdefault.jpg",
                            View = 0
                        });
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.HasIndex("UserId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Country")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Actor", b =>
                {
                    b.HasOne("WebProgrammingMovie.Models.Movie", "Movie")
                        .WithMany("Actor")
                        .HasForeignKey("MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Movie", b =>
                {
                    b.HasOne("WebProgrammingMovie.Models.Category", "Category")
                        .WithMany("movies")
                        .HasForeignKey("CategoryId");

                    b.HasOne("WebProgrammingMovie.Models.Director", "Director")
                        .WithMany("movies")
                        .HasForeignKey("DirectorId");

                    b.Navigation("Category");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Rating", b =>
                {
                    b.HasOne("WebProgrammingMovie.Models.Movie", "Movie")
                        .WithMany("Rating")
                        .HasForeignKey("MovieId");

                    b.HasOne("WebProgrammingMovie.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Movie");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Category", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Director", b =>
                {
                    b.Navigation("movies");
                });

            modelBuilder.Entity("WebProgrammingMovie.Models.Movie", b =>
                {
                    b.Navigation("Actor");

                    b.Navigation("Rating");
                });
#pragma warning restore 612, 618
        }
    }
}