package createCar;

public class EuropeanCarFactory  implements CarFactory{
    @Override
    public Car createCar() {
        return new Sedan();
    }

    @Override
    public CarSpecification createCarSpecification() {
        return new EuropeSpecification();
    }
}
