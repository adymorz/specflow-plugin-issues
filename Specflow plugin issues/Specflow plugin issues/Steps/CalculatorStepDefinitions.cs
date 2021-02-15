using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Specflow_plugin_issues.Steps
{
	[Binding]
	public sealed class CalculatorStepDefinitions
	{
		private readonly ScenarioContext _scenarioContext;

		private const string firstnumberkey = "firstnumber";
		private const string secondnumberkey = "secondnumber";
		private const string resultkey = "result";

		public CalculatorStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given("the first number is (.*)")]
		public void GivenTheFirstNumberIs(int number)
		{
			_scenarioContext[firstnumberkey] = number;
		}

		[Given("the second number is (.*)")]
		public void GivenTheSecondNumberIs(int number)
		{
			_scenarioContext[secondnumberkey] = number;
		}

		[When("the two numbers are added")]
		public void WhenTheTwoNumbersAreAdded()
		{
			_scenarioContext[resultkey] = (int)_scenarioContext[firstnumberkey] + (int)_scenarioContext[secondnumberkey];
		}

		[When("the two numbers are subtracted")]
		public void WhenTheTwoNumbersAreSubtracted()
		{
			_scenarioContext[resultkey] = (int)_scenarioContext[firstnumberkey] - (int)_scenarioContext[secondnumberkey];
		}

		[When("the two numbers are multiplied")]
		public void WhenTheTwoNumbersAreMultiplied()
		{
			_scenarioContext[resultkey] = (int)_scenarioContext[firstnumberkey] * (int)_scenarioContext[secondnumberkey];
		}

		[When("the two numbers are divided")]
		public void WhenTheTwoNumbersAreDivided()
		{
			_scenarioContext[resultkey] = (int)_scenarioContext[firstnumberkey] / (int)_scenarioContext[secondnumberkey];
		}

		[Then("the result should be (.*)")]
		public void ThenTheResultShouldBe(int result)
		{
			Assert.AreEqual(result, _scenarioContext[resultkey], "result does not match expectation");
		}
	}
}
