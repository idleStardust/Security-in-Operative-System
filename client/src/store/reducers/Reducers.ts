import WeatherForecastReducer from "./WeatherForecastReducer";
import CounterReducer from "./CounterReducer";
import ServiceSwitcher from "./ServiceSwitcherReducer";

const reducers = {
    weatherForecasts: WeatherForecastReducer,
    counter: CounterReducer,
    serviceSwitcher: ServiceSwitcher
};

export default reducers