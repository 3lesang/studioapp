using System;
using System.Data.Entity;

namespace winform
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var category1 = context.Categories.Add(new Category { CategoryName = "Romance" });
            var category2 = context.Categories.Add(new Category { CategoryName = "Adventure" });
            var category3 = context.Categories.Add(new Category { CategoryName = "Crime" });
            var category4 = context.Categories.Add(new Category { CategoryName = "Drama" });

            var actor1 = context.Actors.Add(new Actor { ActorName = "Van Hong" });
            var actor2 = context.Actors.Add(new Actor { ActorName = "Bich Phuong Huynh" });
            var actor3 = context.Actors.Add(new Actor { ActorName = "Lan Huong Nguyen" });
            var actor4 = context.Actors.Add(new Actor { ActorName = "Hoai Nam Vo" });
            var actor5 = context.Actors.Add(new Actor { ActorName = "Lam Thanh My" });
            var actor6 = context.Actors.Add(new Actor { ActorName = "Lap Huynh" });
            var actor7 = context.Actors.Add(new Actor { ActorName = "Truong huu Quy" });
            var actor8 = context.Actors.Add(new Actor { ActorName = "The Vinh Truong" });
            var actor9 = context.Actors.Add(new Actor { ActorName = "Tran Thi Nha Phuong" });
            var actor10 = context.Actors.Add(new Actor { ActorName = "Kim Ly" });
            var actor11 = context.Actors.Add(new Actor { ActorName = "Mac Van Khoa" });
            var actor12 = context.Actors.Add(new Actor { ActorName = "Linh Hoai" });
            var actor13 = context.Actors.Add(new Actor { ActorName = "Charlie Nguyen" });
            var actor14 = context.Actors.Add(new Actor { ActorName = "Vi Tu" });
            var actor15 = context.Actors.Add(new Actor { ActorName = "Son Bao Tran" });
            var actor16 = context.Actors.Add(new Actor { ActorName = "Vu T. Le Thi" });
            var actor17 = context.Actors.Add(new Actor { ActorName = "Huy Khanh" });


            var director1 = context.Directors.Add(new Director { DirectorName = "Anh Hung Tran" });
            var director2 = context.Directors.Add(new Director { DirectorName = "Charlie Nguyen" });
            var director3 = context.Directors.Add(new Director { DirectorName = "Le Van Kiet" });
            var director4 = context.Directors.Add(new Director { DirectorName = "Dustin Nguyen" });
            var director5 = context.Directors.Add(new Director { DirectorName = "Thanh Son Le" });
            var director6 = context.Directors.Add(new Director { DirectorName = "Tony Bui" });
            var director7 = context.Directors.Add(new Director { DirectorName = "Stephane Gauger" });
            var director8 = context.Directors.Add(new Director { DirectorName = "Ash Mayfair" });

            var film = new Film
            {
                EnglishTitle = "The Scent of Green Papaya",
                VietnameseTitle = "Mùi Đu Đủ Xanh",
                Year = 1993,
                Length = 104,
                Rating = 7.4000000953674316,
                Gross = 1.91
            };
            context.Films.Add(film);
            film.Directors.Add(director1);
            film.Categories.Add(category1);
            film.Categories.Add(category4);
            film.Actors.Add(actor4);
            film.Actors.Add(actor5);
            film.Actors.Add(actor16);
            film.Actors.Add(actor17);

            film = new Film
            {
                EnglishTitle = "Cyclo",
                VietnameseTitle = "Xích Lô",
                Year = 1995,
                Length = 123,
                Rating = 7.3000001907348633,
                Gross = 0.08
            };
            context.Films.Add(film);
            film.Directors.Add(director1);
            film.Categories.Add(category3);
            film.Categories.Add(category4);
            film.Actors.Add(actor1);
            film.Actors.Add(actor13);
            film.Actors.Add(actor15);
            film.Actors.Add(actor16);

            film = new Film
            {
                EnglishTitle = "The Vertical Ray of the Sun",
                VietnameseTitle = "Mùa Hè Chiều Thẳng Đứng",
                Year = 2000,
                Length = 112,
                Rating = 7.1999998092651367,
                Gross = 0.46
            };
            context.Films.Add(film);
            film.Directors.Add(director1);
            film.Categories.Add(category4);
            film.Actors.Add(actor8);
            film.Actors.Add(actor13);
            film.Actors.Add(actor15);

            film = new Film
            {
                EnglishTitle = "Furie",
                VietnameseTitle = "Hai Phượng",
                Year = 2019,
                Length = 98,
                Rating = 6.3000001907348633,
                Gross = 0.59
            };
            context.Films.Add(film);
            film.Directors.Add(director3);
            film.Categories.Add(category4);
            film.Actors.Add(actor3);
            film.Actors.Add(actor11);
            film.Actors.Add(actor12);

            film = new Film
            {
                EnglishTitle = "Three seasons",
                VietnameseTitle = "Ba Mùa",
                Year = 1999,
                Length = 104,
                Rating = 7.4000000953674316,
                Gross = 1.91
            };
            context.Films.Add(film);
            film.Directors.Add(director6);
            film.Categories.Add(category4);
            film.Actors.Add(actor9);
            film.Actors.Add(actor14);
            film.Actors.Add(actor15);
            film.Actors.Add(actor16);

            film = new Film
            {
                EnglishTitle = "The Rebel",
                VietnameseTitle = "Dòng Máu Anh Hùng",
                Year = 2007,
                Length = 103,
                Rating = 7
            };
            context.Films.Add(film);
            film.Directors.Add(director2);
            film.Categories.Add(category1);
            film.Categories.Add(category4);
            film.Actors.Add(actor3);
            film.Actors.Add(actor13);
            film.Actors.Add(actor14);
            film.Actors.Add(actor16);

            film = new Film
            {
                EnglishTitle = "The Third Wife",
                VietnameseTitle = "Vợ Ba",
                Year = 2018,
                Length = 96,
                Rating = 6.6999998092651367,
                Gross = 0.08
            };
            context.Films.Add(film);
            film.Directors.Add(director8);
            film.Categories.Add(category4);
            film.Actors.Add(actor2);
            film.Actors.Add(actor8);
            film.Actors.Add(actor9);
            film.Actors.Add(actor13);

            film = new Film
            {
                EnglishTitle = "Yellow Flowers on the Green Grass",
                VietnameseTitle = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                Year = 2015,
                Length = 103,
                Rating = 7.5999999046325684
            };
            context.Films.Add(film);
            film.Directors.Add(director4);
            film.Categories.Add(category4);
            film.Actors.Add(actor5);
            film.Actors.Add(actor11);
            film.Actors.Add(actor12);
            film.Actors.Add(actor15);

            film = new Film
            {
                EnglishTitle = "Clash",
                VietnameseTitle = "Bẫy Rồng",
                Year = 2009,
                Length = 90,
                Rating = 6
            };
            context.Films.Add(film);
            film.Directors.Add(director5);
            film.Categories.Add(category3);
            film.Actors.Add(actor6);
            film.Actors.Add(actor7);
            film.Actors.Add(actor14);
            film.Actors.Add(actor16);

            film = new Film
            {
                EnglishTitle = "Owl And The Sparrow",
                VietnameseTitle = "Cú Và Chim Se Sẻ",
                Year = 2007,
                Length = 97,
                Rating = 7.3000001907348633,
                Gross = 0.05
            };
            context.Films.Add(film);
            film.Directors.Add(director7);
            film.Categories.Add(category4);
            film.Actors.Add(actor4);
            film.Actors.Add(actor5);
            film.Actors.Add(actor10);
            film.Actors.Add(actor11);

            context.SaveChanges();
        }
    }
}
