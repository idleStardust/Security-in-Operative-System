import Container from "typedi";
import { WeatherForecastDotnetService } from "../../infrastructure/services/WeatherForecastDotnetService";
import { WeatherForecastService } from "../../infrastructure/services/WeatherForecastService";

export class ServiceSwitcher {
    constructor(
        public service: WeatherForecastService = Container.get(WeatherForecastDotnetService),
    ) { }

}