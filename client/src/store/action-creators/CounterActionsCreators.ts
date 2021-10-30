import { CounterActionType } from "../action-types/CounterActionType";
import { DecrementCountAction, IncrementCountAction, ResetCountAction } from "../actions/CounterActions";

const actionCreators = {
    increment: () => ({ type: CounterActionType.INCREMENT } as IncrementCountAction),
    decrement: () => ({ type: CounterActionType.DECREMENT } as DecrementCountAction),
    reset: () => ({ type: CounterActionType.RESET }) as ResetCountAction
};

export default actionCreators;