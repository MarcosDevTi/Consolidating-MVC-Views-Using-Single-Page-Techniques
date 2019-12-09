using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PTC.Data
{
    public class TrainingProductManager
    {
        public TrainingProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>( );
        }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public bool Validate(TrainingProduct entity)
        {
            ValidationErrors.Clear();
            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("ProductName", "Product Name must not be all lower case."));
                }
            }

            return ValidationErrors.Count == 0;
        }

        public bool Insert(TrainingProduct entity)
        {
            var ret = false;
            ret = Validate(entity);
            if (ret)
            {
                // TODO: Create INSERT code here
            }

            return ret;
        }

        public bool Delete(TrainingProduct entity)
        {
            //TODO: delete code here
            return true;
        }

        public TrainingProduct Get(int productId)
        {
            return CreateMockData().FirstOrDefault(_ => _.ProductId == productId);
        }

        public bool Update(TrainingProduct entity)
        {
            var ret = false;

            ret = Validate(entity);
            if (ret)
            {
                // TODO: Create UPDATE code here
            }

            return ret;
        }


        public List<TrainingProduct> Get(TrainingProduct entity)
        {

            var ret = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.Where(_ =>
                    _.ProductName.ToLower().StartsWith(entity.ProductName, StringComparison.CurrentCultureIgnoreCase));
            }

            return ret.ToList();
        }

        private IQueryable<TrainingProduct> CreateMockData()
        {
            return new List<TrainingProduct>()
            {
                new TrainingProduct
                {
                    ProductId = 1,
                    ProductName = "1 Extending Bootstrap with Css, Javascript and JQuery",
                    IntroductionDate = Convert.ToDateTime("2015-11-06"),
                    Url = "http://bit.ly/lSNzc0i",
                    Price = 29.00M
                },
                new TrainingProduct
                {
                    ProductId = 2,
                    ProductName = "2 Extending Bootstrap with Css, Javascript and JQuery",
                    IntroductionDate = Convert.ToDateTime("2015-11-06"),
                    Url = "http://bit.ly/lSNzc0i",
                    Price = 29.00M
                },
                new TrainingProduct
                {
                    ProductId = 3,
                    ProductName = "3 Extending Bootstrap with Css, Javascript and JQuery",
                    IntroductionDate = Convert.ToDateTime("2015-11-06"),
                    Url = "http://bit.ly/lSNzc0i",
                    Price = 29.00M
                },
                new TrainingProduct
                {
                    ProductId = 4,
                    ProductName = "4 Extending Bootstrap with Css, Javascript and JQuery",
                    IntroductionDate = Convert.ToDateTime("2015-11-06"),
                    Url = "http://bit.ly/lSNzc0i",
                    Price = 29.00M
                }
            }.AsQueryable();
        }
    }
}
