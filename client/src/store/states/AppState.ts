import { Counter } from "./Counter";
import { ServiceSwitcher } from "./ServiceSwitcher";
import { WeatherForecasts } from "./WeatherForecasts";

export interface ApplicationState {
    weatherForecasts: WeatherForecasts;
    counter: Counter,
    serviceSwitcher: ServiceSwitcher
}