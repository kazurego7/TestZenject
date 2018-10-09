using UnityEngine;
using Zenject;

public class TestInstaller : MonoInstaller<TestInstaller> {
    public override void InstallBindings () {
        Container.Bind<INonMono> ().FromInstance (new NonMono1 (1, 'a')).AsTransient ().WhenInjectedInto<BasicType> ();
        Container.Bind<INonMono> ().FromInstance (new NonMono2 (false)).AsTransient ().WhenInjectedInto<BasicType2> ();
    }
}