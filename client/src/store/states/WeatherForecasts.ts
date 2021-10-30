import { WeatherForecast } from "../../infrastructure/models/WeatherForecast";

export class WeatherForecasts {
    constructor(
        public isLoading: boolean = true,
        public forecasts: WeatherForecast[] = [],
        public startDateIndex?: number,
        public error?: any,
    ) {}
}