using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x0200014E RID: 334
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PvpEnableSetRequest : IMessage<PvpEnableSetRequest>, IMessage, IEquatable<PvpEnableSetRequest>, IDeepCloneable<PvpEnableSetRequest>, IBufferMessage
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000F4E RID: 3918 RVA: 0x0019CB0C File Offset: 0x0019AD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PvpEnableSetRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000F4F RID: 3919 RVA: 0x0019CB1C File Offset: 0x0019AD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x0019CB2C File Offset: 0x0019AD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0019CB3C File Offset: 0x0019AD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PvpEnableSetRequest()
		{
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0019CB4C File Offset: 0x0019AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PvpEnableSetRequest(PvpEnableSetRequest other)
		{
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x0019CB5C File Offset: 0x0019AD5C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public PvpEnableSetRequest Clone()
		{
			return null;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x0019CB6C File Offset: 0x0019AD6C
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x0019CB7C File Offset: 0x0019AD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return true;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0019CB8C File Offset: 0x0019AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x0019CB9C File Offset: 0x0019AD9C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(PvpEnableSetRequest other)
		{
			return true;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x0019CBAC File Offset: 0x0019ADAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0019CBBC File Offset: 0x0019ADBC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0019CBCC File Offset: 0x0019ADCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0019CBDC File Offset: 0x0019ADDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0019CBEC File Offset: 0x0019ADEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0019CBFC File Offset: 0x0019ADFC
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(PvpEnableSetRequest other)
		{
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0019CC0C File Offset: 0x0019AE0C
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0019CC1C File Offset: 0x0019AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0019CC2C File Offset: 0x0019AE2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		static PvpEnableSetRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					PvpEnableSetRequest._parser = new MessageParser<PvpEnableSetRequest>(() => null);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_5031fac8c16a43b8b5e515682df08cbd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_fa7a94a3a5d141b3832a6c259d02e750 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 2;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_2290ba9813034fbba04ac0f2768560f3 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
				num2 = 2;
			}
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0019CD10 File Offset: 0x0019AF10
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool uC7kk2OUlJ6asLyBVTIu()
		{
			return true;
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0019CD18 File Offset: 0x0019AF18
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static PvpEnableSetRequest WpNn4AOUctEZqb0BplnB()
		{
			return null;
		}

		// Token: 0x04000594 RID: 1428
		private static readonly MessageParser<PvpEnableSetRequest> _parser;

		// Token: 0x04000595 RID: 1429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000596 RID: 1430
		public const int EnableFieldNumber = 1;

		// Token: 0x04000597 RID: 1431
		private bool enable_;

		// Token: 0x04000598 RID: 1432
		internal static PvpEnableSetRequest aA08c6OUkCUnGZxqCMeO;
	}
}
