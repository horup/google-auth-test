import 'regenerator-runtime/runtime';
import * as React from 'react';
import * as ReactDom from 'react-dom';
import {GoogleLogin} from 'react-google-login';

const id = "583060008999-2c58fnoep6icn3h2mo63khhqe67dmbih.apps.googleusercontent.com";
const secret = "86KwQ5_m2fNOep0CXDfzhcAT";
const responseGoogle = (response) => {
  console.log(response);
}


const Index = ()=>
{
    return (
        <div>
            hello react!
            <GoogleLogin
              clientId={id}
              buttonText="Login"
              onSuccess={responseGoogle}
              onFailure={responseGoogle}
              cookiePolicy={'single_host_origin'}
            />
        </div>
    )
}

ReactDom.render(<Index/>, document.getElementById('main'));