using BepInEx;

namespace Silksong.BuiltTemplate;

// TODO - adjust the plugin guid as needed
[BepInAutoPlugin(id: "io.github.mygithubusername.builttemplate")]
public partial class BuiltTemplatePlugin : BaseUnityPlugin
{
    private void Awake()
    {
        // Put your initialization logic here
        Logger.LogInfo($"Plugin {Name} ({Id}) has loaded!");
    }
}
