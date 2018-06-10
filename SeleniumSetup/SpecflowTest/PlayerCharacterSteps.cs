using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTest
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;
        [Given(@"I am a new player")]
        public void GivenIAmANewPlayer()
        {
            _player = new PlayerCharacter();
        }
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.Hit(0);
        }
        
        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.AreEqual(100, _player.Health);
        }

        [When(@"I take 40 damage")]
        public void WhenITake40Damage()
        {
            _player.Hit(40);
        }

        [Then(@"My health should now be 60")]
        public void ThenMyHealthShouldNowBe60()
        {
            Assert.AreEqual(60, _player.Health);
        }

        [When(@"I take 100 damage")]
        public void WhenITake100Damage()
        {
            _player.Hit(100);
        }

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.AreEqual(0, _player.Health);
        }

    }
}
