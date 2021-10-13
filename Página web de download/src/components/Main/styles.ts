import styled from "styled-components";

export const MainStyle = styled.div`

    display: flex;

    .aside-content {

        flex: 7;
        display: flex;
        flex-direction: column;

    }

    .main-content {

        display: flex;
        flex-direction: column;
        width: 100%;
        max-width: 320px;
        align-items: center;
        text-align: center;

        flex: 8;
        justify-content: center;
        margin: 0;

        border: 5px solid var(--border);

    }

    img {

        height: 100vh;

    }

    p {

        line-height: 65px;
        margin-top: 100px;

        color: var(--text);
        font-family: 'Alegreya', sans-serif;
        font-size: 50px;
        text-align: center;

    }

    .download-icon {

        height: 36px;
        width: 36px;

        margin-left: 10px;
        align-self: center;

    }

    button {

        background-color: #7A7A7A;
        color: #FFFFFF;
        border-radius: 8px;
        font-size: 26px;

        text-decoration: none;

        height: 60px;
        width: 200px;

        margin-bottom: 20px;
        text-align: center;

        display: flex;
        justify-content: center;
        align-items: center;
        cursor: pointer;
        border: 0;

        transition: filter 0.25s;

        margin-top: 100px;

        & + button {
            margin-top: 0;
        }

    }

    #download {

        font-size: 35px;

    }

    button:hover {

        filter: brightness(1.3);

    }

    #available {

        max-width: 150px;

        p {

            line-height: 20px;
            font-size: 15px;
            font-weight: bold;

        }

    }

`