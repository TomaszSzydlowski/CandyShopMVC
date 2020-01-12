using System;
using System.Collections.Generic;
using System.Linq;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _candyRepository = new CategoryRepository();

        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
            new Candy {
                CandyId = 1,
                Name = "Assorted Hard Candy",
                Price = 4.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam in nibh eros. Maecenas eleifend dapibus ipsum. Curabitur ut purus tellus. Cras augue erat, eleifend sit amet fringilla vitae, accumsan eget ante. Nulla aliquam auctor arcu vel ultrices. Vivamus semper metus magna, ut tristique ex placerat et. Sed ante sapien, auctor hendrerit pellentesque a, laoreet interdum enim. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ultricies, sem pharetra porta laoreet, nibh nibh convallis eros, in tempus lorem orci sed ante. Phasellus ornare, lorem non aliquet tincidunt, turpis leo porta augue, ac dignissim tortor massa vel odio. Sed non vulputate nulla. Curabitur sit amet risus est. Duis pretium tempus pulvinar. Aliquam ex tortor, fringilla non ipsum vitae, volutpat commodo quam. Integer imperdiet viverra aliquam. Vestibulum vitae dapibus eros, vitae semper turpis.",
                Category = _candyRepository.GetAllCategorries.ToList()[0],
                ImageUrl = "https://pl.m.wikipedia.org/wiki/Plik:HardCandy.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/HardCandy.jpg/220px-HardCandy.jpg"
            },
            new Candy {
                CandyId = 2,
                Name = "Assorted Hard Candy",
                Price = 2.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam in nibh eros. Maecenas eleifend dapibus ipsum. Curabitur ut purus tellus. Cras augue erat, eleifend sit amet fringilla vitae, accumsan eget ante. Nulla aliquam auctor arcu vel ultrices. Vivamus semper metus magna, ut tristique ex placerat et. Sed ante sapien, auctor hendrerit pellentesque a, laoreet interdum enim. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ultricies, sem pharetra porta laoreet, nibh nibh convallis eros, in tempus lorem orci sed ante. Phasellus ornare, lorem non aliquet tincidunt, turpis leo porta augue, ac dignissim tortor massa vel odio. Sed non vulputate nulla. Curabitur sit amet risus est. Duis pretium tempus pulvinar. Aliquam ex tortor, fringilla non ipsum vitae, volutpat commodo quam. Integer imperdiet viverra aliquam. Vestibulum vitae dapibus eros, vitae semper turpis.",
                Category = _candyRepository.GetAllCategorries.ToList()[1],
                ImageUrl = "https://pl.m.wikipedia.org/wiki/Plik:HardCandy.jpg",
                IsInStock = true,
                IsOnSale = false,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Plain-M%26Ms-Pile.jpg/220px-Plain-M%26Ms-Pile.jpg"
            },
            new Candy {
                CandyId = 3,
                Name = "Assorted Hard Candy",
                Price = 1.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam in nibh eros. Maecenas eleifend dapibus ipsum. Curabitur ut purus tellus. Cras augue erat, eleifend sit amet fringilla vitae, accumsan eget ante. Nulla aliquam auctor arcu vel ultrices. Vivamus semper metus magna, ut tristique ex placerat et. Sed ante sapien, auctor hendrerit pellentesque a, laoreet interdum enim. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Phasellus ultricies, sem pharetra porta laoreet, nibh nibh convallis eros, in tempus lorem orci sed ante. Phasellus ornare, lorem non aliquet tincidunt, turpis leo porta augue, ac dignissim tortor massa vel odio. Sed non vulputate nulla. Curabitur sit amet risus est. Duis pretium tempus pulvinar. Aliquam ex tortor, fringilla non ipsum vitae, volutpat commodo quam. Integer imperdiet viverra aliquam. Vestibulum vitae dapibus eros, vitae semper turpis.",
                Category = _candyRepository.GetAllCategorries.ToList()[2],
                ImageUrl = "https://pl.m.wikipedia.org/wiki/Plik:HardCandy.jpg",
                IsInStock = true,
                IsOnSale = true,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Plain-M%26Ms-Pile.jpg/220px-Plain-M%26Ms-Pile.jpg"
            }
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }
    }
}