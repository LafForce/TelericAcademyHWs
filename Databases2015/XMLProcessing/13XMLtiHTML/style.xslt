<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/">
    <html>
      <style>
        table {
        width: 400
        font-size: 16px;
        text-align: center;
        }

        th, td {
        padding: 5px;
        }
      </style>

      <body>
        <table border="1">
          <tr bgcolor="aqua" style="font-size:0.9em">
            <th>Name</th>
            <th>Artist</th>
            <th>Year</th>
            <th>Producer</th>
            <th>Price</th>
            <th>Songs</th>
            <th>Description</th>
          </tr>
          <xsl:for-each select="music/album">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="artist"/>
              </td>
              <td>
                <xsl:value-of select="year"/>
              </td>
              <td>
                <xsl:value-of select="producer"/>
              </td>
              <td>
                <xsl:value-of select="price"/>$
              </td>
              <td>
                <xsl:for-each select="songList">
                <xsl:for-each select="song">
                  <div>
                    <strong>
                      <xsl:value-of select="title"/>
                    </strong>
                    <xsl:value-of select="length"/>
                  </div>
                </xsl:for-each>
                </xsl:for-each>
              </td>
              <td>
                <xsl:value-of select="description"/>$
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
