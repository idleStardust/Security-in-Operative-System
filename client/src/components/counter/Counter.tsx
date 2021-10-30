import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { ApplicationState } from '../../store/states/AppState';
import * as ActionCreators from '../../store/action-creators/CounterActionsCreators';
import { Counter as CounterState } from '../../store/states/Counter'
import { Text, Button, View } from 'react-native-web-ui-components';

type CounterProps =
    CounterState &
    typeof ActionCreators.default &
    RouteComponentProps<{}>;

class Counter extends React.PureComponent<CounterProps> {
    public render() {
        return (
            <React.Fragment>
                <View>
                <Text>
                    <h1>Counter</h1>

                    <p>This is a simple example of a React component.</p>

                    <p aria-live="polite">Current count: <strong>{this.props.count}</strong></p>
                </Text>

                <Button small onPress={() => this.props.increment()}>
                    Increment
                </Button>
                <Button small onPress={() => this.props.decrement()}>
                    Decrement
                </Button>
                <Button small onPress={() => this.props.reset()}>
                    Reset
                </Button>
                </View>
            </React.Fragment>
        );
    }
};



export default connect(
    (state: ApplicationState) => state.counter,
    ActionCreators.default
)(Counter);
