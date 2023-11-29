public class CarWash implements CarService {
    @Override
    public void service(Car car) {
        System.out.println("Car is being washed at the car wash.");
    }
}