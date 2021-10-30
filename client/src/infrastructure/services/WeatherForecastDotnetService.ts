import { Service } from "typedi";
import { WeatherForecastService } from "./WeatherForecastService";

@Service()
export class WeatherForecastDotnetService extends WeatherForecastService{
    constructor(){
        super('dotnet')
    }
}