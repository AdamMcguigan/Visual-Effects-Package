using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    
    public class ParticleSystemTest
    {
        private ParticleSystem _particleSystem;

        //"Rain Background"
        [SetUp]
        public void Setup()
        {
            ParticleSystem hpBar = MonoBehaviour.Instantiate(Resources.Load<ParticleSystem>("Prefabs/Rain Background"));
        }

        
        [Test]
        public void ParticleSystemIsRunning()
        {
            Assert.IsTrue(_particleSystem.IsAlive());
        }
    }

    [UnityTest]
    public IEnumerator TestHealthBarValue()
    {
        ParticleSystem rainBackground = MonoBehaviour.Instantiate(Resources.Load<ParticleSystem>("Prefabs/Rain Background"));

        bool isPlaying = rainBackground.isPlaying;
        yield return new WaitForSeconds(0.3f);

        Assert.IsFalse(isPlaying);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestScriptSimplePasses()
    {
        // Use the Assert class to test conditions
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
