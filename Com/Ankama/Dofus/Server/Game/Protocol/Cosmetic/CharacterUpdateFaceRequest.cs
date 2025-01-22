using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000C7F RID: 3199
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CharacterUpdateFaceRequest : IMessage<CharacterUpdateFaceRequest>, IMessage, IEquatable<CharacterUpdateFaceRequest>, IDeepCloneable<CharacterUpdateFaceRequest>, IBufferMessage
	{
		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06009992 RID: 39314 RVA: 0x0027BDE4 File Offset: 0x00279FE4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<CharacterUpdateFaceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06009993 RID: 39315 RVA: 0x0027BDF4 File Offset: 0x00279FF4
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

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06009994 RID: 39316 RVA: 0x0027BE04 File Offset: 0x0027A004
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

		// Token: 0x06009995 RID: 39317 RVA: 0x0027BE14 File Offset: 0x0027A014
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateFaceRequest()
		{
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x0027BE24 File Offset: 0x0027A024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateFaceRequest(CharacterUpdateFaceRequest other)
		{
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x0027BE34 File Offset: 0x0027A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterUpdateFaceRequest Clone()
		{
			return null;
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06009998 RID: 39320 RVA: 0x0027BE44 File Offset: 0x0027A044
		// (set) Token: 0x06009999 RID: 39321 RVA: 0x0027BE54 File Offset: 0x0027A054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FaceId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x0600999A RID: 39322 RVA: 0x0027BE64 File Offset: 0x0027A064
		// (set) Token: 0x0600999B RID: 39323 RVA: 0x0027BE74 File Offset: 0x0027A074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Slot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return 0;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
			}
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x0027BE84 File Offset: 0x0027A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x0027BE94 File Offset: 0x0027A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(CharacterUpdateFaceRequest other)
		{
			return true;
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x0027BEA4 File Offset: 0x0027A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x0027BEB4 File Offset: 0x0027A0B4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x0027BEC4 File Offset: 0x0027A0C4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x0027BED4 File Offset: 0x0027A0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x0027BEE4 File Offset: 0x0027A0E4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x0027BEF4 File Offset: 0x0027A0F4
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CharacterUpdateFaceRequest other)
		{
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x0027BF04 File Offset: 0x0027A104
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x0027BF14 File Offset: 0x0027A114
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x0027BF24 File Offset: 0x0027A124
		[MethodImpl(MethodImplOptions.NoInlining)]
		static CharacterUpdateFaceRequest()
		{
			uTJxbl9WRAXV6jfcAd.K9otpUdIVy();
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3c7989f4a2374d0d90bdba8f296a38e1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 3;
					continue;
				case 3:
					CharacterUpdateFaceRequest._parser = new MessageParser<CharacterUpdateFaceRequest>(() => null);
					num2 = 4;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4a9bb6f7d18e454dbf48967fe12c9b88 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				AQ1FWankC0NpFO5PUF5.XVInXhlssT(AQ1FWankC0NpFO5PUF5.F2nnlP452C);
				num2 = 2;
				if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_3e220445ad264b8fac4b36b1feaab002 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x0027C008 File Offset: 0x0027A208
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool VGPbMlJNSKgIC84SNbHS()
		{
			return true;
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x0027C010 File Offset: 0x0027A210
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CharacterUpdateFaceRequest IS0662JNMmAwg6CW6dDF()
		{
			return null;
		}

		// Token: 0x040038F2 RID: 14578
		private static readonly MessageParser<CharacterUpdateFaceRequest> _parser;

		// Token: 0x040038F3 RID: 14579
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038F4 RID: 14580
		public const int FaceIdFieldNumber = 1;

		// Token: 0x040038F5 RID: 14581
		private int faceId_;

		// Token: 0x040038F6 RID: 14582
		public const int SlotFieldNumber = 2;

		// Token: 0x040038F7 RID: 14583
		private int slot_;

		// Token: 0x040038F8 RID: 14584
		internal static CharacterUpdateFaceRequest O9iCT0JNP3NMTjWQXcG4;
	}
}
