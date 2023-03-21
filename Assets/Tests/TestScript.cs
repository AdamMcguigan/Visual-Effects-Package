using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class TestScript
{
    [UnityTest]
    public IEnumerator TestBackgroundRain()
    {
        ParticleSystem rainBackground = MonoBehaviour.Instantiate(Resources.Load<ParticleSystem>("Prefabs/Rain Background"));

        bool isPlaying = rainBackground.isPlaying;
        yield return new WaitForSeconds(0.3f);

        Assert.IsTrue(isPlaying);
    }

    [UnityTest]
    public IEnumerator TestGroundRain()
    {
        ParticleSystem rainBackground = MonoBehaviour.Instantiate(Resources.Load<ParticleSystem>("Prefabs/Rain Ground"));

        bool isPlaying = rainBackground.isPlaying;
        yield return new WaitForSeconds(0.3f);

        Assert.IsTrue(isPlaying);
    }

    [UnityTest]
    public IEnumerator TestForegroundRain()
    {
        ParticleSystem rainBackground = MonoBehaviour.Instantiate(Resources.Load<ParticleSystem>("Prefabs/Rain Front"));

        bool isPlaying = rainBackground.isPlaying;
        yield return new WaitForSeconds(0.3f);

        Assert.IsTrue(isPlaying);
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
