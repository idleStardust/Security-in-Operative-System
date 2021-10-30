import { WeatherForecastActionType } from "../action-types/WeatherForecastActionType";
import { AppThunkAction } from "../actions/AppThunkAction";
import { Action } from "../actions/WeatherForecastActions";

export const actionCreators = {
    request: (startDateIndex: number): AppThunkAction<Action> => async (dispatch, getState) => {
            const appState = getState();

            if (appState && appState.weatherForecasts && startDateIndex !== appState.weatherForecasts.startDateIndex) {
                appState.serviceSwitcher.service.getAll().then(response =>
                    response.data)
                    .then(data => {
                        dispatch({ type: WeatherForecastActionType.SUCCESS, startDateIndex: startDateIndex, forecasts: data });
                    }).catch(e  =>
                        dispatch({ type: WeatherForecastActionType.FAILURE, startDateIndex: startDateIndex, error: e }));

                dispatch({ type: WeatherForecastActionType.REQUEST, startDateIndex: startDateIndex});
            }
        }
};