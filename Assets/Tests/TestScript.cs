using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.VFX;

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

    [UnityTest]
    public IEnumerator TestArcane()
    {
        GameObject arcane = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Arcane Portal"));
        arcane.GetComponent<VisualEffect>().Play();

       // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(3.0f);

        UnityEngine.Assertions.Assert.IsTrue(arcane.GetComponent<VisualEffect>().isActiveAndEnabled);
    }

    [UnityTest]
    public IEnumerator TestLightning()
    {
        GameObject Lightning = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Electricity"));
        Lightning.GetComponent<VisualEffect>().Play();

        // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(1.3f);

        UnityEngine.Assertions.Assert.IsTrue(Lightning.GetComponent<VisualEffect>().isActiveAndEnabled);
    }

    [UnityTest]
    public IEnumerator TestFog()
    {
        GameObject fog = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/FogVFX"));
        fog.GetComponent<VisualEffect>().Play();

        // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(2.0f);

        UnityEngine.Assertions.Assert.IsTrue(fog.GetComponent<VisualEffect>().isActiveAndEnabled);
    }

    [UnityTest]
    public IEnumerator TestCharacter()
    {
        GameObject character = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Character Effect"));
        character.GetComponent<VisualEffect>().Play();

        yield return new WaitForSeconds(0.5f);

        UnityEngine.Assertions.Assert.IsTrue(character.GetComponent<VisualEffect>().isActiveAndEnabled);
    }

    [UnityTest]
    public IEnumerator TestPortal()
    {
        GameObject portal = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Portal"));
        portal.GetComponent<VisualEffect>().Play();

        // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(4.0f);

        UnityEngine.Assertions.Assert.IsTrue(portal.GetComponent<VisualEffect>().isActiveAndEnabled);
    }

    [UnityTest]
    public IEnumerator TestDust()
    {
        GameObject dust = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Dust Particle System"));
        dust.GetComponent<ParticleSystem>().Play();

        // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(0.2f);

        UnityEngine.Assertions.Assert.IsTrue(dust.GetComponent<ParticleSystem>().isPlaying);
    }

    [UnityTest]
    public IEnumerator TestDustStop()
    {
        GameObject dust = MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Dust Particle System"));
        dust.GetComponent<ParticleSystem>().Play();

        // bool isPlaying = arcane.enabled;
        yield return new WaitForSeconds(1.0f);


        UnityEngine.Assertions.Assert.IsFalse(dust.GetComponent<ParticleSystem>().isPlaying);
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
