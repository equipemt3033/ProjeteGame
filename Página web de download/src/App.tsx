import Modal from 'react-modal';
import { useState } from 'react';
import { Main } from "./components/Main"
import { About } from "./components/About";
import { GlobalStyle } from "./styles/global";

Modal.setAppElement('#root');

export function App() {

  const[isAboutModalOpen, setIsAboutModalOpen] = useState(false);

  function handleOpenAboutModal() {
    setIsAboutModalOpen(true);
  }

  function handleCloseAboutModal() {
    setIsAboutModalOpen(false);
  }

  return (
    <>

      <Main onOpenAboutModal={ handleOpenAboutModal }/>
      <About isOpen={ isAboutModalOpen } onRequestClose={ handleCloseAboutModal } />

      <GlobalStyle />

    </>
  );

}