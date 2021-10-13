import Modal from 'react-modal';
import CloseImg from '../../assets/close-icon.png';

interface AboutProps {

    isOpen: boolean;
    onRequestClose: () => void;

}

export function About({ isOpen, onRequestClose }: AboutProps) {
    return(

        <Modal isOpen={ isOpen } onRequestClose={ onRequestClose }
        overlayClassName="react-modal-overlay" className="react-modal-content" >

            <button type="button" onClick={onRequestClose} className="react-modal-close">
                <img src={ CloseImg } alt="Fechar modal" />
            </button>
            
            <p>Um detetive, uma mansão e inúmeros assassinatos. Um jogo regado de mistérios e pistas espalhadas por um cenário com detalhes minimamente pensados. Quem será apto de achar todas as dicas e ligá-las, achando, consequentemente, o assassino? Quantas pessoas ali morreram? Será você quem procuramos?</p>
            <p><strong>Baixe agora e prove que é capaz; ou precisaremos de mais um caixão.</ strong></p>

        </Modal>

    )
}