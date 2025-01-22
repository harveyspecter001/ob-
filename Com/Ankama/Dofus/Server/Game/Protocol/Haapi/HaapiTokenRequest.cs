using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haapi
{
	// Token: 0x020004AE RID: 1198
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HaapiTokenRequest : IMessage<HaapiTokenRequest>, IMessage, IEquatable<HaapiTokenRequest>, IDeepCloneable<HaapiTokenRequest>, IBufferMessage
	{
		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x001E1A0C File Offset: 0x001DFC0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<HaapiTokenRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06003944 RID: 14660 RVA: 0x001E1A1C File Offset: 0x001DFC1C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x001E1A2C File Offset: 0x001DFC2C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06003946 RID: 14662 RVA: 0x001E1A3C File Offset: 0x001DFC3C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenRequest()
		{
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x001E1A4C File Offset: 0x001DFC4C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenRequest(HaapiTokenRequest other)
		{
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x001E1A5C File Offset: 0x001DFC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public HaapiTokenRequest Clone()
		{
			return null;
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x001E1A6C File Offset: 0x001DFC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600394A RID: 14666 RVA: 0x001E1A7C File Offset: 0x001DFC7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(HaapiTokenRequest other)
		{
			return true;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x001E1A8C File Offset: 0x001DFC8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x001E1A9C File Offset: 0x001DFC9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x001E1AAC File Offset: 0x001DFCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x001E1ABC File Offset: 0x001DFCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x001E1ACC File Offset: 0x001DFCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x001E1ADC File Offset: 0x001DFCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(HaapiTokenRequest other)
		{
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x001E1AEC File Offset: 0x001DFCEC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x001E1AFC File Offset: 0x001DFCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x001E1B0C File Offset: 0x001DFD0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static HaapiTokenRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 4;
					continue;
				case 2:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_812627316728402097d051e8c3077157 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					continue;
				case 4:
					HaapiTokenRequest._parser = new MessageParser<HaapiTokenRequest>(() => null);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_0a5cd06d4d53488ca9d53d8fa419e8e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x001E1BD8 File Offset: 0x001DFDD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool qTr99IOQBhUjN0TeBLeb()
		{
			return true;
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x001E1BE0 File Offset: 0x001DFDE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static HaapiTokenRequest aZyRRUOQe9Vxcs9PYvd4()
		{
			return null;
		}

		// Token: 0x040013F9 RID: 5113
		private static readonly MessageParser<HaapiTokenRequest> _parser;

		// Token: 0x040013FA RID: 5114
		private UnknownFieldSet _unknownFields;

		// Token: 0x040013FB RID: 5115
		private static HaapiTokenRequest wLgREpOQAJTJLJ8H997N;
	}
}
