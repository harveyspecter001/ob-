using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CeFcm4kuMpCvdFmV8C;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic
{
	// Token: 0x02000CB9 RID: 3257
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OutfitEquipFaceRequest : IMessage<OutfitEquipFaceRequest>, IMessage, IEquatable<OutfitEquipFaceRequest>, IDeepCloneable<OutfitEquipFaceRequest>, IBufferMessage
	{
		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06009C8A RID: 40074 RVA: 0x00281998 File Offset: 0x0027FB98
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		public static MessageParser<OutfitEquipFaceRequest> Parser
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return null;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06009C8B RID: 40075 RVA: 0x002819A8 File Offset: 0x0027FBA8
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

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06009C8C RID: 40076 RVA: 0x002819B8 File Offset: 0x0027FBB8
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

		// Token: 0x06009C8D RID: 40077 RVA: 0x002819C8 File Offset: 0x0027FBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceRequest()
		{
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x002819D8 File Offset: 0x0027FBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceRequest(OutfitEquipFaceRequest other)
		{
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x002819E8 File Offset: 0x0027FBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public OutfitEquipFaceRequest Clone()
		{
			return null;
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06009C90 RID: 40080 RVA: 0x002819F8 File Offset: 0x0027FBF8
		// (set) Token: 0x06009C91 RID: 40081 RVA: 0x00281A08 File Offset: 0x0027FC08
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
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

		// Token: 0x06009C92 RID: 40082 RVA: 0x00281A18 File Offset: 0x0027FC18
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object other)
		{
			return true;
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x00281A28 File Offset: 0x0027FC28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(OutfitEquipFaceRequest other)
		{
			return true;
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x00281A38 File Offset: 0x0027FC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06009C95 RID: 40085 RVA: 0x00281A48 File Offset: 0x0027FC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06009C96 RID: 40086 RVA: 0x00281A58 File Offset: 0x0027FC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WriteTo(CodedOutputStream output)
		{
		}

		// Token: 0x06009C97 RID: 40087 RVA: 0x00281A68 File Offset: 0x0027FC68
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
		}

		// Token: 0x06009C98 RID: 40088 RVA: 0x00281A78 File Offset: 0x0027FC78
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int CalculateSize()
		{
			return 0;
		}

		// Token: 0x06009C99 RID: 40089 RVA: 0x00281A88 File Offset: 0x0027FC88
		[GeneratedCode("protoc", null)]
		[DebuggerNonUserCode]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(OutfitEquipFaceRequest other)
		{
		}

		// Token: 0x06009C9A RID: 40090 RVA: 0x00281A98 File Offset: 0x0027FC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MergeFrom(CodedInputStream input)
		{
		}

		// Token: 0x06009C9B RID: 40091 RVA: 0x00281AA8 File Offset: 0x0027FCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
		}

		// Token: 0x06009C9C RID: 40092 RVA: 0x00281AB8 File Offset: 0x0027FCB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		static OutfitEquipFaceRequest()
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
					num2 = 3;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_d0ed3a751ca8432aa19e676130332441 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					xpZugWn58BGXRHuIEsv.XVInXhlssT(xpZugWn58BGXRHuIEsv.jbRnymgi9i);
					num2 = 1;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_65a4bcb260b64c5f8f7680ba04c739cd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					UaHTHGncBpWINMKqtkM.XVInXhlssT(UaHTHGncBpWINMKqtkM.eRKnUxpo02);
					num2 = 0;
					if (<Module>{844fa171-30ca-4421-b897-27f0adac0be0}.m_88c3861d95fd4f7989074e8e239c17e8.m_4b8749bf652542ac9b363b68e0ada0c3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					return;
				}
				OutfitEquipFaceRequest._parser = new MessageParser<OutfitEquipFaceRequest>(() => null);
				num2 = 4;
			}
		}

		// Token: 0x06009C9D RID: 40093 RVA: 0x00281B9C File Offset: 0x0027FD9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool GGMoMZJ4XTnavL7tVSyK()
		{
			return true;
		}

		// Token: 0x06009C9E RID: 40094 RVA: 0x00281BA4 File Offset: 0x0027FDA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static OutfitEquipFaceRequest QtrIQWJ4NOyfGNM9xLHL()
		{
			return null;
		}

		// Token: 0x04003A0E RID: 14862
		private static readonly MessageParser<OutfitEquipFaceRequest> _parser;

		// Token: 0x04003A0F RID: 14863
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A10 RID: 14864
		public const int FaceIdFieldNumber = 1;

		// Token: 0x04003A11 RID: 14865
		private int faceId_;

		// Token: 0x04003A12 RID: 14866
		internal static OutfitEquipFaceRequest QOlTJaJ4EGBuq135805c;
	}
}
