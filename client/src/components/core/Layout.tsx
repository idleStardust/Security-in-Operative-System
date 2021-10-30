import * as React from 'react';
import NavMenu from './NavMenu';
import { MainContainer } from 'react-native-web-ui-components';
import { Platform, StyleSheet, View } from 'react-native';
import { StylePropType } from 'react-native-web-ui-components';
import PropTypes from 'prop-types';

const styles = StyleSheet.create({
    empty: {},
    defaults: {
        flex: 1,
        justifyContent: 'flex-start',
        alignItems: 'flex-start',
        backgroundColor: '#FFFFFF',
        minHeight: Platform.OS === 'web' ? '100vh' : '100%',
        width: '100%',
    },
});

const Layout = ({ style, children }) => (
    <View style={styles.defaults}>
        <React.Fragment>
            <NavMenu />
            <MainContainer>
                {children}
            </MainContainer>
        </React.Fragment>
    </View>
);

Layout.propTypes = {
    style: StylePropType,
    children: PropTypes.node,
};

Layout.defaultProps = {
    style: styles.empty,
    children: null,
};

export default Layout;