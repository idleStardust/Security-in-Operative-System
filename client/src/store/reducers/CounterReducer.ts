import { Reducer } from "react";
import { CounterActionType as ActionType } from "../action-types/CounterActionType";
import { Action } from "../actions/CounterActions";
import { Counter } from "../states/Counter";

const initialState = new Counter();

export const reducer: Reducer<Counter, Action> = (state: Counter | undefined, action: Action): Counter => {
    if (state === undefined)
        return initialState;

    let count = state.count;
    
    switch (action.type) {
        case ActionType.INCREMENT:
            return new Counter(++count);
        case ActionType.DECREMENT:
            return new Counter(--count);
        case ActionType.RESET:
            return new Counter();
        default:
            return state;
    }
}

export default reducer;