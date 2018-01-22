using Kata;
using System.Collections.Generic;
using Xunit;

namespace Kata.Test
{
  
  public class When_an_empty_list_is_passed
  {
    TotalsCalculator SUT;
    IEnumerable<ListItem> Items;
    decimal Result;

    public When_an_empty_list_is_passed()
    {
      Items = new List<ListItem>(); 
      SUT = new TotalsCalculator();
      Result = SUT.CalculateTotals(Items);
    }

    [Fact]
    public void it_should_return_zero()
    {
      Assert.True(Result.Equals(0));
    }
  }
}