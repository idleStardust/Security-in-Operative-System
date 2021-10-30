import * as React from 'react';
import { StyleSheet, Platform, View } from 'react-native';
import { Container, IconText, Row, Column, Hr, WebOnly } from 'react-native-web-ui-components';
import { Link } from 'react-router-native';

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

export default class NavMenu extends React.PureComponent<{}, { isOpen: boolean }> {
    public state = {
        isOpen: false,
    };

    public render() {
        return (
            <WebOnly>
                <Row style={styles.row}>
                    <Container>
                        <Column xs={6} style={styles.leftColumn}>
                            <Link to="/" className="text-dark">
                                <IconText iconName='home' type="navy" auto style={styles.logo}>
                                    Home
                                </IconText>
                            </Link>
                        </Column>
                        <Column xs={6} style={styles.rightColumn}>
                            <Link to="/counter" className="text-dark">
                                <View style={styles.menuRow}>
                                    <IconText iconName='sun-cloud'>
                                        Counter
                                    </IconText>
                                </View>
                            </Link>
                        </Column>
                        <Column xs={6} style={styles.rightColumn}>
                            <Link to="/fetch-data" className="text-dark">
                                <View style={styles.menuRow}>
                                    <IconText iconName='sun-cloud'>
                                        Weather Forecast
                                    </IconText>
                                </View>
                            </Link>
                        </Column>
                    </Container>
                </Row>
                <Hr />
            </WebOnly>
        )
    }
}