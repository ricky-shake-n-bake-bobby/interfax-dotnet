using NUnit.Framework;

namespace InterFAX.Api.Test.Unit
{
    [TestFixture]
    public class OutboundListOptionsTests
    {
        [Test]
        public void should_return_dictionary_of_options()
        {
            var listOptions = new Outbound.ListOptions
            {
                LastId = 10,
                Limit = 20,
                UserId = "unit-test-userid",
                SortOrder = ListSortOrder.Ascending
            };

            var actual = listOptions.ToDictionary();
            Assert.AreEqual(4, actual.Keys.Count);

            var key = "lastId";
            Assert.That(actual.ContainsKey(key));
            Assert.AreEqual(listOptions.LastId.ToString(), actual[key]);

            key = "limit";
            Assert.That(actual.ContainsKey(key));
            Assert.AreEqual(listOptions.Limit.ToString(), actual[key]);

            key = "userId";
            Assert.That(actual.ContainsKey(key));
            Assert.AreEqual(listOptions.UserId, actual[key]);

            key = "sortOrder";
            Assert.That(actual.ContainsKey(key));
            Assert.AreEqual("asc", actual[key]);
        }
    }
}