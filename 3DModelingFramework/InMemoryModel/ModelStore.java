import java.util.ArrayList;

public class ModelStore implements IModelChangeObserver, IModelChanger {

    // List of models
    ArrayList<PoligonalModel> models = new ArrayList<>();

    // List of scenes
    ArrayList<Scene> scenes = new ArrayList<>();

    // List of flashes
    ArrayList<Flash> flashes = new ArrayList<>();

    // List of cameras
    ArrayList<Camera> cameras = new ArrayList<>();

    // Get scene by index
    public Scene getScene(int sceneIndex) {
        return scenes.get(sceneIndex);
    }

    @Override
    public void notifyChange() {
        // TODO: Implement
    }

    @Override
    public void applyUpdateModel() {
        // TODO: Implement
    }
}