using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Gamemap
{
	// Token: 0x02000578 RID: 1400
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MapMovementConfirmRequest : IMessage<MapMovementConfirmRequest>, IMessage, IEquatable<MapMovementConfirmRequest>, IDeepCloneable<MapMovementConfirmRequest>, IBufferMessage
	{
		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x001F4F94 File Offset: 0x001F3194
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<MapMovementConfirmRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x001F4FA4 File Offset: 0x001F31A4
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

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x001F4FB4 File Offset: 0x001F31B4
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

		// Token: 0x06004368 RID: 17256 RVA: 0x001F4FC4 File Offset: 0x001F31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementConfirmRequest()
		{
		}

		// Token: 0x06004369 RID: 17257 RVA: 0x001F4FD4 File Offset: 0x001F31D4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementConfirmRequest(MapMovementConfirmRequest other)
		{
		}

		// Token: 0x0600436A RID: 17258 RVA: 0x001F4FE4 File Offset: 0x001F31E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public MapMovementConfirmRequest Clone()
		{
			return null;
		}

		// Token: 0x0600436B RID: 17259 RVA: 0x001F4FF4 File Offset: 0x001F31F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600436C RID: 17260 RVA: 0x001F5004 File Offset: 0x001F3204
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(MapMovementConfirmRequest other)
		{
			return true;
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x001F5014 File Offset: 0x001F3214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x001F5024 File Offset: 0x001F3224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x001F5034 File Offset: 0x001F3234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x001F5044 File Offset: 0x001F3244
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x001F5054 File Offset: 0x001F3254
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x001F5064 File Offset: 0x001F3264
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(MapMovementConfirmRequest other)
		{
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x001F5074 File Offset: 0x001F3274
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x001F5084 File Offset: 0x001F3284
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x001F5094 File Offset: 0x001F3294
		[MethodImpl(MethodImplOptions.NoInlining)]
		static MapMovementConfirmRequest()
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
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_a371ce0cfcbd4291a6964a1215024a3c != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_ead98ae52f7d4114bccb31c3ab7f1ef3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_7f74a282136744a483473eaa16349e22 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				MapMovementConfirmRequest._parser = new MessageParser<MapMovementConfirmRequest>(() => null);
				num2 = 3;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c6f185c11294dcda9d0164d4dd81e26 == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x001F518C File Offset: 0x001F338C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool RBNQuAOHu5gMEAhDWgCg()
		{
			return true;
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x001F5194 File Offset: 0x001F3394
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static MapMovementConfirmRequest QTF4nrOH8O7pPp8Py9eH()
		{
			return null;
		}

		// Token: 0x0400173C RID: 5948
		private static readonly MessageParser<MapMovementConfirmRequest> _parser;

		// Token: 0x0400173D RID: 5949
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400173E RID: 5950
		private static MapMovementConfirmRequest oypEAnOHMybnnuFqpfTI;
	}
}
