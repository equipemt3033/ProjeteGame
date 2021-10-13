import { createGlobalStyle } from 'styled-components';

export const GlobalStyle = createGlobalStyle`

    :root {

        --background: #ECECEC;
        --border: #424242;
        --text: #000000;
        --button-background: #7A7A7A;
        --button-text: #FFFFFF;

    }

    * {

        margin: 0;
        padding: 0;

    }

    html {

        @media (max-width: 1080px) {
            font-size: 93.75%;
        }

        @media (max-width: 720px) {
            font-size: 87.5%;
        }

    }

    body {

        background: var(--background);
        -webkit-font-smoothing: antialiased;

    }

    body, button {

        font-family: 'Alegreya', sans-serif;

    }

    button {

        cursor: pointer;

    }
    .react-modal-overlay {

        background: rgba(0, 0, 0, 0.5);

        position: fixed;
        top: 0;
        bottom: 0;
        right: 0;
        left: 0;

        display: flex;
        align-items: center;
        justify-content: center;

        backdrop-filter: blur(2px);

    }

    .react-modal-content {

        width: 100%;
        max-width: 450px;
        background: var(--background);
        padding: 2.5rem;
        position: relative;
        border-radius: 15px;

        font-size: 22px;
        
    }

    .react-modal-close {

        img {

            height: 28px;
            width: 28px;

        }

        position: absolute;
        right: 12px;
        top: 12px;
        border: 0;
        background: transparent;

        &:hover {
            filter: brightness(0.8);
        }

    }

`