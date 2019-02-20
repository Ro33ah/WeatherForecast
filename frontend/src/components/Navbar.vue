<template>
  <b-navbar
    toggleable="md"
    type="dark"
    variant="info">
    <b-navbar-brand :to="{ name: 'Home' }"> He Goes Nowhere>_></b-navbar-brand>
    <b-navbar-nav>
      <b-nav-item href="#">Neither Does He>_></b-nav-item>
      <b-nav-item href="#">We All Go Nowhere :'(</b-nav-item>
    </b-navbar-nav>
  </b-navbar>
</template>

<script>
export default {
  name: 'Navbar'
};
</script>