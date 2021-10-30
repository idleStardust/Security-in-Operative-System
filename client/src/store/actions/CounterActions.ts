import { Action as ReduxAction } from "redux";
import { CounterActionType } from "../action-types/CounterActionType";

interface CounterAction extends ReduxAction<CounterActionType> {
    type: CounterActionType
}
export interface IncrementCountAction extends CounterAction {
    type: CounterActionType.INCREMENT
}
export interface DecrementCountAction extends CounterAction {
    type: CounterActionType.DECREMENT
}

export interface ResetCountAction extends CounterAction {
    type: CounterActionType.RESET
}

export type Action = IncrementCountAction | DecrementCountAction | ResetCountAction