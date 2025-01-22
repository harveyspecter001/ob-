using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Social
{
	// Token: 0x02000148 RID: 328
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JoinSpouseRequest : IMessage<JoinSpouseRequest>, IMessage, IEquatable<JoinSpouseRequest>, IDeepCloneable<JoinSpouseRequest>, IBufferMessage
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0019C4D0 File Offset: 0x0019A6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JoinSpouseRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x0019C4E0 File Offset: 0x0019A6E0
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

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x0019C4F0 File Offset: 0x0019A6F0
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

		// Token: 0x06000F03 RID: 3843 RVA: 0x0019C500 File Offset: 0x0019A700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinSpouseRequest()
		{
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0019C510 File Offset: 0x0019A710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinSpouseRequest(JoinSpouseRequest other)
		{
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x0019C520 File Offset: 0x0019A720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JoinSpouseRequest Clone()
		{
			return null;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0019C530 File Offset: 0x0019A730
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0019C540 File Offset: 0x0019A740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(JoinSpouseRequest other)
		{
			return true;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0019C550 File Offset: 0x0019A750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0019C560 File Offset: 0x0019A760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0019C570 File Offset: 0x0019A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0019C580 File Offset: 0x0019A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0019C590 File Offset: 0x0019A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0019C5A0 File Offset: 0x0019A7A0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(JoinSpouseRequest other)
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0019C5B0 File Offset: 0x0019A7B0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x0019C5C0 File Offset: 0x0019A7C0
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x0019C5D0 File Offset: 0x0019A7D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		static JoinSpouseRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_844c3d3d44cb4b74b471bc211c845a0b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d5b1c5ad0ad745e2b5fbdc5f1a54d277 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				JoinSpouseRequest._parser = new MessageParser<JoinSpouseRequest>(() => null);
				num2 = 3;
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0019C6B4 File Offset: 0x0019A8B4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool AryWjmOUEYDcHrt7cfml()
		{
			return true;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x0019C6BC File Offset: 0x0019A8BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static JoinSpouseRequest q4NuVZOUXTA5fDuRpWFt()
		{
			return null;
		}

		// Token: 0x0400057F RID: 1407
		private static readonly MessageParser<JoinSpouseRequest> _parser;

		// Token: 0x04000580 RID: 1408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000581 RID: 1409
		internal static JoinSpouseRequest w0Pdo9OU2B5RffuOaB5o;
	}
}
