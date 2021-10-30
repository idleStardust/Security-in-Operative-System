import { WeatherForecast } from "../models/WeatherForecast";
import { Service as ServiceTemplate } from "./Service";
import { APIRoute } from "./APIRoute";

export abstract class WeatherForecastService extends ServiceTemplate<WeatherForecast>{
    constructor(path?: string){
        super(APIRoute.WeatherForecast, path)
    }
}