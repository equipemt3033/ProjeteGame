import IllustrationImg from '../../assets/illustration.png';
import DownloadImg from '../../assets/download-icon.png';
import { MainStyle } from './styles';

interface MainProps {

    onOpenAboutModal: () => void;

}

export function Main({ onOpenAboutModal }: MainProps) {

    return(

        <>

            <MainStyle>

                <div className="aside-content">

                    <img src={ IllustrationImg } alt="Ilustração do jogo" />

                </div>

                <div className="main-content">

                    <p>CASO SEM SAÍDA</p>

                    <button type="button" onClick={ onOpenAboutModal } >
                        SOBRE O JOGO
                    </button>

                    <button type="button" id="download" >
                        BAIXAR
                        <img src={ DownloadImg } className="download-icon" alt="Download icon"/>
                    </button>

                    <div id="available">
                        <p>DISPONÍVEL APENAS PARA WINDOWS</p>
                    </div>

                </div>
                
            </MainStyle>

        </>

    )

}