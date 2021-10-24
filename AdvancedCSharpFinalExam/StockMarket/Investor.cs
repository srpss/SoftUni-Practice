using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public List<Stock> Portfolio = new List<Stock>();
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            List<Stock> Portfolio = new List<Stock>();
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
        }
        public int Count => Portfolio.Count;
        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest - stock.PricePerShare > 0)
            {
                Portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            for (int i = 0; i < Portfolio.Count; i++)
            {
                if (Portfolio[i].CompanyName == companyName)
                {
                    if (Portfolio[i].PricePerShare > sellPrice)
                    {
                        return $"Cannot sell {companyName}.";
                    }
                    else
                    {
                        MoneyToInvest += sellPrice;
                        Portfolio.RemoveAt(i);
                        return $"{companyName} was sold.";
                    }
                }
            }
            return $"{companyName} does not exist.";
        }
        public Stock FindStock(string companyName)
        {
            for (int i = 0; i < Portfolio.Count; i++)
            {
                if (Portfolio[i].CompanyName == companyName)
                {
                    return Portfolio[i];
                }
            }
            return null;
        }
        public Stock FindBiggestCompany()
        {
            Stock biggest = new Stock("test", "test", 00.00m, 00);
            bool check = false;
            for (int i = 0; i < Portfolio.Count; i++)
            {
                if (Portfolio[i].MarketCapitalization > biggest.MarketCapitalization)
                {
                    biggest = Portfolio[i];
                    check = true;
                }
            }
            if (check == false)
            {
                return null;
            }
            else
            {
                return biggest;
            }           
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:".TrimEnd());
            foreach (var item in Portfolio)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
