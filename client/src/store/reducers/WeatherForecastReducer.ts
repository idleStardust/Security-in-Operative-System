import { Reducer } from 'redux'
import { WeatherForecastActionType } from '../action-types/WeatherForecastActionType'
import { Action } from '../actions/WeatherForecastActions'
import { WeatherForecasts } from '../states/WeatherForecasts'

const initialState: WeatherForecasts = new WeatherForecasts();

const reducer: Reducer<WeatherForecasts, Action> = (
    state: WeatherForecasts | undefined = initialState,
    action: Action,
): WeatherForecasts => {
    if (state === undefined) return initialState
    switch (action.type) {
        case WeatherForecastActionType.SUCCESS:
            if (action.startDateIndex === state.startDateIndex)
                return {
                    startDateIndex: action.startDateIndex,
                    forecasts: action.forecasts,
                    isLoading: false,
                    serviceType: state.serviceType
                };
            break;
        case WeatherForecastActionType.REQUEST:
            return {
                startDateIndex: action.startDateIndex,
                forecasts: state.forecasts,
                isLoading: true,
                serviceType: state.serviceType
            }
        case WeatherForecastActionType.FAILURE:
            return {
                startDateIndex: action.startDateIndex,
                forecasts: state.forecasts,
                isLoading: false,
                error: action.error,
                serviceType: state.serviceType
            }
        default:
            return state
    }
}

export default reducer;
