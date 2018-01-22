using Kata;
using System;
using System.Collections.Generic;
using Machine.Specifications;

namespace Kata.MachineTest
{
  public class When_the_list_is_empty
  {
    static TotalsCalculator SUT;
    static IEnumerable<ListItem> Items;
    static decimal Result;

    Establish context = () =>
    {
      SUT = new TotalsCalculator();
      Items = new List<ListItem>();
    };

    Because of = () =>
    {
      Result = SUT.CalculateTotals(Items);
    };

    It should_return_zero = () => Result.ShouldEqual(0);
  }
}
