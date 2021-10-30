import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-native';
import { WeatherForecast } from '../../infrastructure/models/WeatherForecast';
import { WeatherForecasts } from '../../store/states/WeatherForecasts';
import { actionCreators as WeatherForecastActionCreators } from '../../store/action-creators/WeatherForecastActionsCreators'
import { ApplicationState } from '../../store/states/AppState';
import { StyleSheet, Platform, View } from 'react-native';
import { Spinner } from 'react-native-web-ui-components';
import { Button, Row, Text, Container, Column } from 'react-native-web-ui-components';
import { ServiceSwitcher } from '../../store/states/ServiceSwitcher';
import ServiceSwitcherActionsCreators from '../../store/action-creators/ServiceSwitcherActionsCreators';

const styles = StyleSheet.create({
  row: {
    paddingTop: Platform.OS === 'web' ? 20 : 35,
    justifyContent: 'center',
  },
  leftColumn: {
    height: 50,
    justifyContent: 'center',
  },
  rightColumn: {
    height: 50,
    alignItems: 'flex-end',
    justifyContent: 'center',
  },
  menuRow: {
    flexDirection: 'row',
    alignItems: 'center',
    justifyContent: 'flex-end',
  },
  menuItem: {
    paddingRight: 15,
  },
  logo: {
    fontSize: 20,
  },
});

// At runtime, Redux will merge together...
type Props =
  WeatherForecasts // ... state we've requested from the Redux store
  & ServiceSwitcher
  & typeof WeatherForecastActionCreators // ... plus action creators we've requested
  & typeof ServiceSwitcherActionsCreators
  & RouteComponentProps<{ startDateIndex: string }>; // ... plus incoming routing parameters


class FetchData extends React.PureComponent<Props> {
  // This method is called when the component is first added to the document
  public componentDidMount() {
    this.ensureDataFetched();
  }

  // This method is called when the route parameters change
  public componentDidUpdate() {
    this.ensureDataFetched();
  }

  public render() {
    return (
      <View>
        <React.Fragment>
          <h1 id="tabelLabel">Weather forecast</h1>
          <p>This component demonstrates fetching data from the server and working with URL parameters.</p>
          <Text>Choose API</Text>
            <Button small onPress={() => this.props.requestDotnet()}>
              .Net
            </Button>
            
            <Button small onPress={() => this.props.requestPython()}>
              Python
            </Button>
          <>{this.checkLoading()}</>
        </React.Fragment>
      </View>
    );
  }

  private checkLoading() {
    if (this.props.isLoading === undefined || this.props.isLoading)
      return (<Spinner />);
    else{
      const error = this.props.error;
      if(error){
        console.log(error);
        return(<View>
          <Text>
            There was an error loading the content
          </Text>
        </View>)
      }
      else
      return (<View>
        {this.renderForecastsTable()}
        {this.renderPagination()}
      </View>);
    }
  }


  private ensureDataFetched() {
    const startDateIndex = parseInt(this.props.match.params.startDateIndex, 10) || 0;
    this.props.request(startDateIndex);
  }

  private renderForecastsTable() {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
          </tr>
        </thead>
        <tbody>
          {this.props.forecasts.map((forecast: WeatherForecast) =>
            <tr key={forecast.date}>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  private renderPagination() {
    const prevStartDateIndex = (this.props.startDateIndex || 0) - 5;
    const nextStartDateIndex = (this.props.startDateIndex || 0) + 5;

    return (
      <View>
        <Row style={styles.row}>
          <Container>

            <Column xs={6} style={styles.leftColumn}>
              <Link to={`/fetch-data/${prevStartDateIndex}`}>
                <Text>
                  Previous
                </Text>
              </Link>
            </Column>

            <Column xs={6} style={styles.leftColumn}>
              <Link to={`/fetch-data/${nextStartDateIndex}`}>
                <Text>
                  Next
                </Text>
              </Link>
            </Column>

          </Container>
        </Row>
      </View>
    );
  }
}

export default connect(
  (state: ApplicationState) => ({...state.weatherForecasts, ...state.serviceSwitcher}),
  ({...WeatherForecastActionCreators, ...ServiceSwitcherActionsCreators})
  )(FetchData as any);
