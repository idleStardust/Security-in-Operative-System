import { WeatherForecastActionType } from "../action-types/WeatherForecastActionType";
import { Action as ReduxAction} from "redux";
import { WeatherForecast } from "../../infrastructure/models/WeatherForecast";
import { ServiceType } from "../helpers/ServiceType";

interface WeatherForecastAction extends ReduxAction<WeatherForecastActionType> {
    type: WeatherForecastActionType;
    startDateIndex: number;
}

export interface RequestWeatherForecastAction extends WeatherForecastAction {
    type: WeatherForecastActionType.REQUEST;
}

export interface SuccessWeatherForecastAction extends WeatherForecastAction {
    type: WeatherForecastActionType.SUCCESS;
    forecasts: WeatherForecast[];
}

export interface FailureWeatherForecastAction extends WeatherForecastAction {
    type: WeatherForecastActionType.FAILURE;
    error: any;
}

export type Action = RequestWeatherForecastAction | SuccessWeatherForecastAction | FailureWeatherForecastAction;