import { Reducer } from "react";
import Container from "typedi";
import { WeatherForecastDotnetService } from "../../infrastructure/services/WeatherForecastDotnetService";
import { ServiceSwitcherActionType as ActionType } from "../action-types/ServiceSwitcherActionType";
import { Action } from "../actions/ServiceSwitcherActions";
import { ServiceSwitcher } from '../states/ServiceSwitcher'

const initialState = new ServiceSwitcher();

export const reducer: Reducer<ServiceSwitcher, Action> = (state: ServiceSwitcher = initialState, action: Action) :
 ServiceSwitcher => {
    switch (action.type) {
        case ActionType.DOTNET:
            return { service: Container.get(WeatherForecastDotnetService)};
        default: 
            return state;
    }
}

export default reducer;